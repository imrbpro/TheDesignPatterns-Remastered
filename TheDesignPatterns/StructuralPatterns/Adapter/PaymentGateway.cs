using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDesignPatterns.StructuralPatterns.Adapter
{
    public  class PaymentGateway
    {
        public void Pay(decimal amount, string customerId, string customerCvc)
        {
            //payment processing logic whatever easypaisa or paypal business logic 

        }
    }
}
