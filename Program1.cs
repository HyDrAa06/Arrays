using System;

namespace CoffeeOrders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Count of orders:");
            int countOfOrders = int.Parse(Console.ReadLine());


            double[] totalExpenses= new double[countOfOrders];

            for (int i = 0; i < countOfOrders; i++)
            {

                Console.WriteLine("Price per capsule:");
                double PricePerCapsule = double.Parse(Console.ReadLine());

                Console.WriteLine("Days:");
                int days = int.Parse(Console.ReadLine());

                Console.WriteLine("Capsule count:");
                int capsuleCount = int.Parse(Console.ReadLine());

                totalExpenses[i] = ((days * capsuleCount) * PricePerCapsule);

                Console.WriteLine("The price for the coffee is ${0}",totalExpenses[i].ToString("#.##"));
            }

            Console.WriteLine("Total: ${0}", totalExpenses.Sum().ToString("#.##"));
            
        }
    }
}