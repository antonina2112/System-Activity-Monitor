using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace SAMWebService.Models
{
    [DataContract]
    public class StatisticsModel
    {
        [DataMember]
        public int Amount { get; set; }
        [DataMember]
        public string Title { get; set; }
    }
}
