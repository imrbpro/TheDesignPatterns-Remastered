using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDesignPatterns.BehavioralPatterns.COR
{
    public class President : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.price <= 100000)
            {
                Console.WriteLine("{0} approved request # {1} for buying {2} of amount {3}",
                    this.GetType().Name, purchase.number, purchase.purpose, purchase.price);
            }
            else  
            {
                Console.WriteLine("Request # {0} requires a board of directors meeting!", purchase.number);
            }
        }
    }
}
