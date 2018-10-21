using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lynda_LINQ_Essentials
{
    class Program
    {
        static readonly List<Customer> customers = new List<Customer>
        {
            new Customer {First = "Cailin", Last = "Alford",  State = "GA"},
            new Customer {First = "Theodore", Last = "Brock",  State = "AR"},
            new Customer {First = "Adena", Last = "Jenkins",  State = "OR"},
            new Customer {First = "Jerry", Last = "Gill",  State = "MI"},
            new Customer {First = "Sydney", Last = "Bartlett",  State = "OR"}
        };


        static void Main(string[] args)
        {
            var stateQuery =
                    from cust in customers
                    where cust.State == "OR"
                    select cust;

            foreach (var state in stateQuery)
            {
                Console.WriteLine($"{state.Last}, {state.First}" );
            }

        }
    }
}
