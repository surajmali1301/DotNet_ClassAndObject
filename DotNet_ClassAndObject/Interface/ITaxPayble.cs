using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_ClassAndObject.Interface
{
    public interface ITaxPayble
    {
        double Tax();
    }

    public class Job : ITaxPayble 
    {
        private double taxAmount;
        private double salary;

        public Job()
        {
            salary = 20000;
        }
        public double Tax()
        {
            taxAmount = salary * 0.20;
            return taxAmount;
        }
    }

    public class Business : ITaxPayble 
    { 
        private double taxAmount;
        private double income;
        public Business()
        {
            income = 100000;
        }
        public double Tax()
        {
            taxAmount = income * 0.30;
            return taxAmount;
        }
    }



}
