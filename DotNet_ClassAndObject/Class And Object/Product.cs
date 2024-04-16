using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_ClassAndObject
{
    public  class Product
    {
        private int pId;
        private string name;
        private double price;

        public double Price { get => price; set => price = value; }
        public int PId { get => pId; set => pId = value; }
        public string Name { get => name; set => name = value; }



        //public int pID {
        //    set{ pId = value; }
        //    get{return pId; }
        //}
      

    }
}
