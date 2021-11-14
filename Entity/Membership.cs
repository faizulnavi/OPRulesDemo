using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPRulesDemo.Entity
{
    class Membership : NonPhysicalProduct
    {
        public Membership()
        {
            CheckoutProcess = new List<string>();
            base.GenerateCustomerSlip();
            CheckoutProcess.Add("Membership Activated");
            Console.WriteLine("Membership Activated");
            base.SendEmail();
        }
    }
}
