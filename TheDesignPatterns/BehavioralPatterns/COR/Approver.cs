using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDesignPatterns.BehavioralPatterns.COR
{
    public abstract class Approver
    {
        protected Approver _Successor;
        public void SetSuccessor(Approver successor)
        {
            _Successor = successor;
        }
        public abstract void ProcessRequest(Purchase purchase);
    }
}
