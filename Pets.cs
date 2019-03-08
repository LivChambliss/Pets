using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Pets
{
    class Pet
    {
        public string name, owner, type;
        public double weight;
        public Pet(string type, string name, string owner, double weight)
        {
            this.name = name;
            this.type = type;
            this.owner = owner;
            this.weight = weight;
        }
        public string getTag()
        {
            return "if lost, call " + this.name;
        }
    }
}