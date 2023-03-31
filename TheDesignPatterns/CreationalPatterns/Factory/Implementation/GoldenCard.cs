using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheDesignPatterns.CreationalPatterns.Factory.Interface;

namespace TheDesignPatterns.CreationalPatterns.Factory.Implementation
{
    public class GoldenCard : ICardType
    {
        public int CardCharges()
        {
            return 2000;
        }

        public int CardLimit()
        {
            return 50000;
        }

        public string CardType()
        {
            return "GOLDEN CARD";
        }

        public int CardValidity()
        {
            return 2025;
        }
    }
}
