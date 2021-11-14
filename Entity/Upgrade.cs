using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPRulesDemo.Entity
{
    class Upgrade : NonPhysicalProduct
    {
        public Upgrade()
        {
            CheckoutProcess = new List<string>();
            base.GenerateCustomerSlip();
            CheckoutProcess.Add("Membership Upgraded");
            Console.WriteLine("Membership Upgraded");
            base.SendEmail();
        }
    }
}
