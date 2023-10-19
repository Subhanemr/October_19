using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_10_23.Metods
{
    internal class Apple : Fruit
    {
        public double VitaminA { get; set; }
        public double VitaminB { get; set; }

        public override void Taste()
        {
            Console.WriteLine("Taste of Apple");
        }
    }
}
