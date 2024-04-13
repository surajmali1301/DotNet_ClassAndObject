using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_ClassAndObject
{
    public class Employee
    {
        private int empid;
        private String empname;
        private double bs, hra, pf,gross;

        //Contructor is Special method
        /*Constructor same name has Class name
          It does not return any thing we cannot use return type with it
          When we create class object Constructor get invoked
         */
        public Employee()
        {

        }


        public void Assign()
    {
        empid = 1;
        empname = "Suraj";
        bs = 24000;
        hra = 2000;
        pf = 1000;
            gross = (bs + hra)-pf;

            Console.Write($"From Assign Method \nempId: {empid} \nEmp_name: {empname} \nSalary: {gross}\n----------------");

    }

        public void Accept(int id,String name,double bs,double h,double p)
        {
            empid = id;
            empname = name;
            this.bs = bs;
            hra = h;
            pf = p;

        }

        public void CalculateSalary()
        {
             gross = (bs + hra) - pf;
        }

        public String display()
        {
            return $"\nFrom Display method\nempid: {empid}, \nempname: {empname} \nSalary: {gross}";
        }
    }

}
