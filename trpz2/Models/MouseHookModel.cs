using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace trpz2.Models
{
    public class MouseHookModel
    {
        public string EventType { get; set; }

        public string Button { get; set; }

        public string X { get; set; }

        public string Y { get; set; }
    }
}
