using DotNet_ClassAndObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_ClassAndObject
{
    public class Manager:Employee
    {

        private double food;
        //Contructor is Special method
        /*Constructor same name has Class name
          It does not return any thing we cannot use return type with it
          When we create class object Constructor get invoked
         */
        public Manager():base()
        {

        }

        public Manager(int id, String name, double bs, double h, double p,double food):base(id,name,bs,h,p)
        {
            this.food = food;
        }

        public override void CalculateSalary()
        {
            gross = (bs + hra) - pf;
        }

        public override String Display()
        {
            return $"\nManager Salary \nempid: {empid}, \nempname: {empname} \nSalary: {gross}";
        }
    }

}
