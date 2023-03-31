using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheDesignPatterns.CreationalPatterns.Factory.Implementation;
using TheDesignPatterns.CreationalPatterns.Factory.Interface;

namespace TheDesignPatterns
{    class Program
    {
        static void Main(string[] args)
        {
            ICardType cardType = null;
            Console.WriteLine("Enter your Desired Card Name");
            string choice = Console.ReadLine();
            switch (choice.ToLower())
            {
                case "silver":
                    cardType = new SilverCard();
                    GetCardDetails(cardType);
                    break;
                case "golden":
                    cardType = new GoldenCard();
                    GetCardDetails(cardType);
                    break;
                case "platinium":
                    cardType = new PlatiniumCard();
                    GetCardDetails(cardType);
                    break;
                default:
                    cardType = null;
                    GetCardDetails(cardType);
                    break;
            }
        }

        public static void GetCardDetails(ICardType cardType)
        {
            if(cardType != null)
            {
                Console.WriteLine("Card Type is : "+cardType.CardType());
                Console.WriteLine("Card Validity is : "+cardType.CardValidity());
                Console.WriteLine("Card Limit is : "+cardType.CardLimit());
                Console.WriteLine("Card Annual Charges are : "+cardType.CardCharges());
            }
            else
            {
                Console.WriteLine("Invalid Card Type");
            }

        }
    }
}
