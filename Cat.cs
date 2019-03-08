using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Pets
{
    class Cat:Pet
    {
        public Cat(string name, string owner, double weight)
        :base("cat", name, owner, weight)
        {
        }
        public string meow(int count)
        {
            string str = "";
            for (int i = 0; i < count; i++)
                str += "meow.";
            return str;
        }
    }
}