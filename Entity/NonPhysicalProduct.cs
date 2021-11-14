using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPRulesDemo.Entity
{
    public abstract class NonPhysicalProduct : Product
    {
        public override void GenerateCustomerSlip()
        {
            CheckoutProcess.Add("Generate a packing slip for shipping.");
            Console.WriteLine("Generate a packing slip for shipping.");
        }
        public virtual void SendEmail()
        {
            CheckoutProcess.Add("Mail Sent to customer");
            Console.WriteLine("Mail Sent to customer");
        }
    }
}
