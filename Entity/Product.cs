using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPRulesDemo.Entity
{
    public abstract class Product
    {
        public string Name { get; set; }
        public List<string> CheckoutProcess { get; set; }
        public abstract void GenerateCustomerSlip();
    }
}
