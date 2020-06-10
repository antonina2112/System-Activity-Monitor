﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace WebSysActMon.Models
{
    [DataContract]
    public class Performance
    {
        [DataMember]
        public DateTime Time { get; set; }
        [DataMember]
        public float Value { get; set; }
    }
}
