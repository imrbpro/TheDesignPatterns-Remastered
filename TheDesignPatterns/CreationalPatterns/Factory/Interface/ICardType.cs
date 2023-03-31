using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDesignPatterns.CreationalPatterns.Factory.Interface
{
    public interface ICardType
    {
        string CardType();
        int CardLimit();
        int CardCharges();
        int CardValidity();
    }
}
