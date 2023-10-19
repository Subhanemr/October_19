using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_10_23.Metods
{
    internal class Orange : Fruit
    {
        public double VitaminC { get; set; }

        public override void Taste()
        {
            Console.WriteLine("Taste of Orange");
        }
    }
}
