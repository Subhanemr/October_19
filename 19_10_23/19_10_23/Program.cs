using System.Reflection;
using _19_10_23.Metods;

namespace _19_10_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fruit[] Basket = new Fruit[]
            {
                new Apple { Price = 1.0m, Sort = new string[] { "Malus communis ", "Malus pumila" }, VitaminA = 10, VitaminB = 5 },
                new Pineapple { Price = 2.5m, Sort = new string[] { "Abacaxi", "Pernambuco " }, VitaminE = 8, VitaminD = 6 },
                new Orange { Price = 0.75m, Sort = new string[] { "Blood", "Tangerine" }, VitaminC = 20 }
            };

            foreach (Fruit fruit in Basket)
            {
                Console.WriteLine("Type: " + fruit.GetType().Name);
                fruit.Taste();
                foreach (var property in fruit.GetType().GetProperties())
                {
                    if (property.PropertyType.IsArray)
                    {
                        Array array = (Array)property.GetValue(fruit);
                        Console.Write($"{property.Name}: ");
                        foreach (var item in array)
                        {
                            Console.Write(item + ", ");
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine($"{property.Name}: {property.GetValue(fruit)}");
                    }
                }
                Console.WriteLine();
            }
            
        }
    }
}