using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GrangeiroApp.ServiceReference1;

namespace GrangeiroApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client client = new Service1Client();

            string name = client.GetName();
            string sobrenome = client.GetSobrenome();

            CreateOrderRequest request = new CreateOrderRequest();
            request.AmountInCents = 500;
            request.CreditCardNumber = "1234567890123456";
            request.HolderName = "Luis Grangeiro";
            request.MerchantKey = Guid.Parse("8A2DD57F-1ED9-4153-B4CE-69683EFADAD5");
            request.OrderNumber = "1";

            CreateOrderResponse response = client.CreateOrder(request);
            if (response.Success)
            {
                Console.WriteLine("Compra efetuada com sucesso!");
                Console.WriteLine(@"
                                  Buyer: {0}
                                  AmountInCents: {1}
                                  OrderKey: {2}
                                  Success: {3}
                                  CreditCardNumber: {4}", response.HolderName, response.AmountInCents, response.OrderKey.ToString(), response.Success, response.CreditCardNumber);
            }
            else
            {
                Console.WriteLine("Compra não realizada!");
                Console.WriteLine(@"
                                  Buyer: {0} 
                                  AmountInCents: {1}
                                  ErrorDescription: {2}
                                  Success: {3}", response.HolderName, response.AmountInCents, response.ErrorDescription, response.Success);
            }
            Console.ReadKey();
        }
    }
}
