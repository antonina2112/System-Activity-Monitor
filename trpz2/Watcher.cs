using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Permissions;
using System.Text;

namespace trpz2
{
    public class Watcher
    {
        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        public static void Run()
        {
            string[] args = Environment.GetCommandLineArgs();

            if (args.Length != 2)
            {
                Console.WriteLine("Usage: Watcher.exe (directory)");
                return;
            }

            using (FileSystemWatcher watcher = new FileSystemWatcher())
            {
                watcher.Path = args[1];

                watcher.NotifyFilter = NotifyFilters.LastAccess
                    | NotifyFilters.LastWrite
                    | NotifyFilters.FileName
                    | NotifyFilters.DirectoryName;

                watcher.Filter = "*.txt";

                watcher.Changed += OnChanged;
                watcher.Created += OnChanged;
                watcher.Deleted += OnChanged;
                watcher.Renamed += OnChanged;

                watcher.EnableRaisingEvents = true;

                Console.WriteLine("Press 'q' to quit the sample.");
                while (Console.Read() != 'q') ;
            }

        }

        private static void OnChanged(object source, FileSystemEventArgs e) =>
            Console.WriteLine($"File: {e.FullPath} {e.ChangeType}");
        private static void OnRenamed(object source, RenamedEventArgs e) =>
            Console.WriteLine($"File: {e.OldFullPath} renamed to {e.FullPath}");
    }
}
