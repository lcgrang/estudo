using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServiceTest
{
    [DataContract]
    public class CreateOrderRequest
    {
        [DataMember]
        public Guid MerchantKey { get; set; }

        [DataMember]
        public int AmountInCents { get; set; }

        [DataMember]
        public string CreditCardNumber { get; set; }

        [DataMember]
        public string HolderName { get; set; }

        [DataMember]
        public int SecurityCode { get; set; }

        [DataMember]
        public string OrderNumber { get; set; }

    }
}