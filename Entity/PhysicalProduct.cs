using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPRulesDemo.Entity
{
    public abstract class PhysicalProduct : Product
    {
        public override void GenerateCustomerSlip()
        {
            CheckoutProcess.Add("Generated a packing slip for shipping.");
            Console.WriteLine("Generated a packing slip for shipping.");
        }
        public virtual void AddCommission()
        {
            CheckoutProcess.Add("Commission payment to the agent");
            Console.WriteLine("Commission payment to the agent");
        }
    }
}
