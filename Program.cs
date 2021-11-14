using OPRulesDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPRulesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Orders order = new Orders();
            Console.WriteLine("Enter Product type and name ");
            var input = Console.ReadLine().Split(' ');
            var output = Orders.CompleteOrder(input);
            //Console.WriteLine("Item Name : {0} Operations : {1}", output.Name, string.Join(" ", output.CheckoutProcess));
            Console.ReadLine();
        }
    }
}
