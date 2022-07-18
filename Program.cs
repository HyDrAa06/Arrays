using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRotations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array value: ");
            int arrayValue=int.Parse(Console.ReadLine());
            int[]array=new int[arrayValue];

            for(int i = 0; i < arrayValue; i++)
            {
                Console.WriteLine("{0} element: ",i+1);
                array[i]=int.Parse(Console.ReadLine());
            }
            
            
            

            Console.WriteLine("Number of rotations");
            int rotationsNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < rotationsNumber; i++)
            {
                int temporary = array[0];
                for (int j = 1; j < array.Length; j++)
                {
                    array[j - 1] = array[j];
                }

                array[array.Length - 1] = temporary;

            }
            

            Console.WriteLine(String.Join(" ", array));

            Console.ReadLine();
        }
    }
}
