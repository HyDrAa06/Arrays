using System;

namespace Ladybugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Field size:");
            int fieldSize=int.Parse(Console.ReadLine());
            if(fieldSize<0 || fieldSize > 1000)
            {
                throw new ArgumentException("Invalid field size.");
            }

            int[] field = new int[fieldSize];

            Console.WriteLine("Indexes of ladybugs:");
            int[] ladybugIndex = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            for (int i = 0; i < ladybugIndex.Length; i++)
            {
                field[ladybugIndex[i]] = 1;
            }

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Current index, direction, fly length: ");
                string[] path = Console.ReadLine().Split(" ");

                if (path[0] == "end")
                {
                    break;
                }

                int currentPosition = int.Parse(path[0]);
                string direction = path[1];
                int flyLength = int.Parse(path[2]);
                int nextPosition = 0;

                if (flyLength < 0)
                {
                    if (direction == "right")
                    {
                        direction = "left";
                    }
                    if (direction == "left")
                    {
                        direction="right";
                    }
                }

                if(direction == "right")
                {
                    nextPosition = flyLength + currentPosition;
                }
                if(direction == "left")
                {
                    nextPosition =currentPosition - flyLength;
                }

                for(int j=0; j < ladybugIndex.Length; j++)
                {
                    field[ladybugIndex[j]] = 0;

                    if (field.Length <= nextPosition)
                    {
                        nextPosition = 0;
                    }

                    if (field[0] >= nextPosition)
                    {
                        nextPosition = 0;
                    }

                    if (field[nextPosition] == 1 )
                    {
                        
                        if (direction == "right")
                        {
                            nextPosition++;
                        }
                        if(direction== "left")
                        {
                            nextPosition--;
                        }
                        
                    }
                    
                }
                field[nextPosition] = 1;
            }

            Console.WriteLine(String.Join(" ",field));
            

        }
    }
}
