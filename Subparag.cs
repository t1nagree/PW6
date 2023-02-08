using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    internal class Subparag
    {
        public int price;
        public string name;
        public string type;
        public Subparag()
        {
        }
        public Subparag(int price, string name, string type)
        {
            this.name = name;
            this.price = price;
            this.type = type;
        }
    }
}
