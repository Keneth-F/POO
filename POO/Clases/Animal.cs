using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Clases
{
    public class Animal
    {
        public Animal(string id, string raza, double edad)
        {
            this.id = id;
            this.raza = raza;
            this.edad = edad;
        }
        public Animal()
        {
            
        }
        public string id { get; set; }
        public string raza { get; set; }
        public double edad { get; set; }
    }
}
