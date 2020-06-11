using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace SAMWebService.Models
{
    [DataContract]
    public class WindowInfo
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Date { get; set; }
    }
}
