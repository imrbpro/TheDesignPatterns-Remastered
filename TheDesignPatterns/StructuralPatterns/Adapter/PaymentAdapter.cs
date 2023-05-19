using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDesignPatterns.StructuralPatterns.Adapter
{
    public class PaymentAdapter : IPaymentProcessor
    {
        private readonly PaymentGateway _jazzcash;
        public PaymentAdapter(PaymentGateway paymentGateway) { 
            _jazzcash = paymentGateway;
        }
        public void ProcessPayment(decimal amount)
        {
            _jazzcash.Pay(10000, "rehan", "123");
        }
    }
}
