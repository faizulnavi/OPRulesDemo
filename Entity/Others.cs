using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPRulesDemo.Entity
{
    class Others : PhysicalProduct
    {
        public Others(string name)
        {
            Name = name;
            CheckoutProcess = new List<string>();
            base.GenerateCustomerSlip();
            base.AddCommission();
        }
    }
}
