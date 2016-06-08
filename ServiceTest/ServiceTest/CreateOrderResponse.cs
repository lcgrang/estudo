using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServiceTest
{
    [DataContract]
    public class CreateOrderResponse
    {
        [DataMember]
        public bool Success { get; set; }

        [DataMember]
        public string HolderName { get; set; }

        [DataMember]
        public int AmountInCents { get; set; }

        [DataMember]
        public string ErrorDescription { get; set; }

        [DataMember]
        public Guid OrderKey { get; set; }

        [DataMember]
        public string CreditCardNumber { get; set; }

        [DataMember]
        public Guid MerchantKey { get; set; }
    }
}