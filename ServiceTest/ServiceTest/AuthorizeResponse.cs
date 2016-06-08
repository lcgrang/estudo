using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServiceTest
{
    [DataContract]
    public class AuthorizeResponse
    {
        [DataMember]
        public bool Authorized { get; set; }

        [DataMember]
        public string ReturnMessage { get; set; }
    }
}