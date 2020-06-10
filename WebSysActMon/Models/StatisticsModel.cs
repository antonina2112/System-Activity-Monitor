using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace WebSysActMon.Models
{
    [DataContract]
    public class StatisticsModel
    {
        [DataMember]
        public int Amount { get; set; }
        [DataMember]
        [MaxLength(20)]
        public string Title { get; set; }
    }
}
