using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDesignPatterns.BehavioralPatterns.COR
{
    public class Director : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if(purchase.price <= 10000)
            {
                Console.WriteLine("{0} approved request # {1} for buying {2} of amount {3}", 
                    this.GetType().Name, purchase.number, purchase.purpose, purchase.price);
            }
            else if(_Successor != null)
            {
                _Successor.ProcessRequest(purchase);
            }
        }
    }
}
