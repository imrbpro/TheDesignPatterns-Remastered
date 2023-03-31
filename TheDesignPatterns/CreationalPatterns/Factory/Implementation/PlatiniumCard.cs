using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheDesignPatterns.CreationalPatterns.Factory.Interface;

namespace TheDesignPatterns.CreationalPatterns.Factory.Implementation
{
    public class PlatiniumCard : ICardType
    {
        public int CardCharges()
        {
            return 3000;
        }

        public int CardLimit()
        {
            return 100000;
        }

        public string CardType()
        {
            return "PLATINIUM CARD";
        }

        public int CardValidity()
        {
            return 2030;
        }
    }
}
