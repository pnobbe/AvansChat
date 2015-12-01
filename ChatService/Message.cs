using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ChatService
{
    [DataContract]
    public class Message
    {
        [DataMember]
        public string Content { get; set; }

        [DataMember]
        public DateTime TimeStamp { get; set; }

        [DataMember]
        public string User { get; set; }
    }

}