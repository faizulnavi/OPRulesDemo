using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPRulesDemo.Entity
{
    class Book : PhysicalProduct
    {
        public Book(string productName)
        {
            Name = productName;
            CheckoutProcess = new List<string>();
            base.GenerateCustomerSlip();
            base.AddCommission();
            GenerateCustomerSlip();
        }
        public override void GenerateCustomerSlip()
        {
            CheckoutProcess.Add("Create a duplicate packing slip for the royalty department.");
            Console.WriteLine("Create a duplicate packing slip for the royalty department.");
        }
    }
}
