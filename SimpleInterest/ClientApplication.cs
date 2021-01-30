using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleInterest
{
    class ClientApplication
    {
        public static void Main(string[] args)
        {
            InterestFactory factory = null;
            Console.WriteLine("Enter the interest type: ");
            string _type = Console.ReadLine();

            switch (_type.ToLower())
            {
                case "simple":
                    factory = new SimpleInterestFactory();
                    break;
                case "compound":
                    factory = new CompoundInterestFactory();
                    break;
                default:
                    break;
            }

            MasterInterest master = factory.GetInterest();

            Console.WriteLine("Interest Details are below:");
            Console.WriteLine("Interest Type : {0}\n Amount : {1}\n Interest : {2}\n Years : {3}\n Total Amount (Month) : {4}",
                master.InterestType, master.Amount, master.Interest, master.Years, master.TotalAmount);
            Console.ReadKey();

        }
    }
}
