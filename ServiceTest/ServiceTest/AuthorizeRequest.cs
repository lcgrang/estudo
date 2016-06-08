using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceTest
{
    [DataContract]
    public class AuthorizeRequest
    {
        [DataMember]
        public string CreditCardNumber { get; set; }

        [DataMember]
        public string HolderName { get; set; }

        [DataMember]
        public int SecurityCode { get; set; }

        [DataMember]
        public int AmountInCents { get; set; }

    }
}
