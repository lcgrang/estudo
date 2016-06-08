using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace ServiceTest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public string GetName()
        {
            return "O seu nome é Luis";
        }

        public string GetSobrenome()
        {
            return "Grangeiro";
        }

        public CreateOrderResponse CreateOrder(CreateOrderRequest request)
        {
            CreateLog(request);
            CreateOrderResponse response = new CreateOrderResponse();
            response.Success = false;

            if (request.MerchantKey == Guid.Parse("8A2DD57F-1ED9-4153-B4CE-69683EFADAD5"))
            {
                if (request.AmountInCents < 1000)
                {
                    response.Success = true;
                    response.HolderName = request.HolderName;
                    response.AmountInCents = request.AmountInCents;
                    StringBuilder builder = new StringBuilder(request.CreditCardNumber);
                    builder.Remove(4, 8);
                    builder.Insert(4, "*", 6);
                    response.CreditCardNumber = builder.ToString();
                    response.MerchantKey = request.MerchantKey;
                    response.OrderKey = System.Guid.NewGuid();
                }
                else
                {
                    response.ErrorDescription = "Cliente não possui dinheiro suficiente";
                }
            }
            else
            {
                response.ErrorDescription = "Loja não autorizada";
            }
            
            return response;
        }

       public void CreateLog(CreateOrderRequest request)
       {
           string xmlString = Serializa(request);

           using (StreamWriter outputFile = new StreamWriter("C:\\Users\\lgrangeiro.MPAGG\\Documents\\Visual Studio 2013\\Projects\\GrangeiroApp\\Teste.log", true))
           {
               DateTime hoje = DateTime.Now;
               StringBuilder logString = new StringBuilder(hoje + xmlString);
               outputFile.WriteLine(logString);
           }

       }

        public string Serializa(CreateOrderRequest request)
        {
            XmlSerializer xsSubmit = new XmlSerializer(request.GetType());

            using (StringWriter sww = new StringWriter())
            using (XmlWriter writer = XmlWriter.Create(sww))
            {
                xsSubmit.Serialize(writer, request);
                var xml = sww.ToString();

                return xml;
            }
            
        }

        protected AuthorizeRequest Authorize(CreateOrderRequest order)
        {
            AuthorizeRequest authorize = new AuthorizeRequest();

            authorize.CreditCardNumber = order.CreditCardNumber;
            authorize.SecurityCode = order.SecurityCode;
            authorize.AmountInCents = order.AmountInCents;

            return authorize;
        }
    }
}
