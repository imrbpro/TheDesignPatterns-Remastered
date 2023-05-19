using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheDesignPatterns.BehavioralPatterns.COR;

namespace TheDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Approver Ali = new Director();
            Approver Asfahan = new VicePresident();
            Approver Shoaib = new President();

            Ali.SetSuccessor(Asfahan);
            Asfahan.SetSuccessor(Shoaib);

            //Purchase pr = new Purchase(1001, 9500, "Assests");

            //Purchase pr = new Purchase(1002, 19500, "Offices");

            Purchase pr = new Purchase(1003, 119500, "Acquiring ChatGPT");
            Ali.ProcessRequest(pr);
            

            Console.Read();
        }
    }
}
