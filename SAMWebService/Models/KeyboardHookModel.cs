using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace SAMWebService.Models
{
    [DataContract]
    public class KeyboardHookModel
    {
        [DataMember]
        public string EventType { get; set; }
        [DataMember]
        public string Time { get; set; }
        [DataMember]
        public string KeyChar { get; set; }
    }
}
