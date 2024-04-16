using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_ClassAndObject.Static
{
    public class StaticKeyword_Use
    {

        private int id;
        private string name;
        private static int count;//0

        public int Id { get; set; }
        public string Name { get; set; }
        public StaticKeyword_Use()
        {
            count++;
            id = count;
            name = "Suraj";
        }

        public StaticKeyword_Use(string name)
        {
            count++;
            this.id = count;
            this.name = name;
        }

        public String Display()
        {
            return $"Id: {id}\n Name: {name}";
        }
    }
}
