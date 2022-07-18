using System;

namespace JediAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Budget:");
            double budget=double.Parse(Console.ReadLine());

            Console.WriteLine("Count of students:");
            int studentsCount =int.Parse(Console.ReadLine());

            Console.WriteLine("The price for a single lightsaber: ");
            double lightsaberPrice = double.Parse(Console.ReadLine());
            
            Console.WriteLine("The price for a single robe:");
            double robePrice = double.Parse(Console.ReadLine());

            Console.WriteLine("The price for a single belt:");
            double beltPrice= double.Parse(Console.ReadLine());

            double[] totalForEachStudent=new double[studentsCount];
            double totalForAll=0;

            for(int i = studentsCount; i>0; i--)
            {
                if (i % 6 == 0)
                {
                    totalForEachStudent[i-1] = lightsaberPrice + robePrice;
                }

                else
                {
                    totalForEachStudent[i-1] = lightsaberPrice + robePrice + beltPrice;
                }

                totalForAll = totalForAll + totalForEachStudent[i-1];                
            }

            totalForAll = totalForAll + (lightsaberPrice * (Math.Ceiling(studentsCount*0.10)));


            if (budget >= totalForAll)
            {
                Console.WriteLine("The money is enough. It will cost {0}.", totalForAll);
            }

            if(budget < totalForAll)
            {
                double more = totalForAll - budget;
                Console.WriteLine("John will need {0} money more.",more);
            }
        }
    }
}

