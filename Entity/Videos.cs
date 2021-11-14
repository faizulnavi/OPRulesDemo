using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPRulesDemo.Entity
{
    class Videos : NonPhysicalProduct
    {
        public Videos(string vName)
        {
            CheckoutProcess = new List<string>();
            Name = vName;

            GenerateCustomerSlip();
        }
        public override void GenerateCustomerSlip()
        {
            base.GenerateCustomerSlip();
            if (Name.ToLower().Equals("learning to ski"))
            {
                CheckoutProcess.Add("'First Aid' added to the packing slip");
                Console.WriteLine("'First Aid' added to the packing slip");
            }
        }
    }
}
