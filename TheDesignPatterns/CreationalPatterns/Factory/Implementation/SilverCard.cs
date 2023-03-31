using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using TheDesignPatterns.CreationalPatterns.Factory.Interface;

namespace TheDesignPatterns.CreationalPatterns.Factory.Implementation
{
    public class SilverCard : ICardType
    {
        public int CardCharges()
        {
            return 1000;
        }

        public int CardLimit()
        {
            return 25000;
        }

        public string CardType()
        {
            return "SILVER CARD";
        }

        public int CardValidity()
        {
            return 2024;
        }
    }
}
