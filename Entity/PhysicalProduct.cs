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
            CheckoutProcess.Add("Generate a packing slip for shipping.");
            Console.WriteLine("Generate a packing slip for shipping.");
        }
        public virtual void AddCommission()
        {
            CheckoutProcess.Add("Commission generated for agent");
            Console.WriteLine("Commission generated for agent");
        }
    }
}
