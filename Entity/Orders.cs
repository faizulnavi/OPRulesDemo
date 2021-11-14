using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPRulesDemo.Entity
{
    public class Orders
    {
        public static Product CompleteOrder(string[] input)
        {
            ProductType type;
            try
            {
                type = (ProductType)Enum.Parse(typeof(ProductType), input[0], ignoreCase: true);
            }
            catch (Exception e)
            {
                type = ProductType.Other;
            }
            Product product;
            string name = input.Length > 1 ? string.Join(" ", input, 1, input.Length - 1) : string.Empty;
            switch (type)
            {
                case ProductType.Membership:
                    {
                        product = new Membership();
                        break;
                    }
                case ProductType.Upgrade:
                    {
                        product = new Upgrade();
                        break;
                    }
                case ProductType.Video:
                    {
                        product = new Videos(name);
                        break;
                    }
                case ProductType.Book:
                    {
                        product = new Book(name);
                        break;
                    }
                case ProductType.Other:
                default:
                    {
                        product = new Others(name);
                        break;
                    }
            }
            return product;
        }
    }
}
