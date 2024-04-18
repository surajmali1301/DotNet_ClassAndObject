using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_ClassAndObject.Interface
{
    public interface ICustomer 
    {
        string print();
    }

    public interface ICustomerOrder
    {
        string print();
    }

    public class Transactiion : ICustomer, ICustomerOrder
    {
        string ICustomer.print()
        {
            return "Customer Details";
        }

        string ICustomerOrder.print()
        {
            return "Customer Order Details";
        }
    }
}
