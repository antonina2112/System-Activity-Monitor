using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SAMWebService.Models
{
    [DataContract]
    public class MouseHookModel
    {
        [DataMember]
        public string EventType { get; set; }
        [DataMember]
        public string Button { get; set; }
        [DataMember]
        public string X { get; set; }

        [DataMember]
        public string Y { get; set; }
    }
}
