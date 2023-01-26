using System.Collections.Generic;
using System.ComponentModel.Design;

namespace Codility
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine(solution(new int[] { 1, 3, 6, 4, 1, 2 }));
            Console.WriteLine("This is for github");
            Console.WriteLine("Another line for github");
            Console.WriteLine("This is the commit for user interface");

        }

        // testing changes

        public static int solution(int[] A)
        {
            Array.Sort(A);

            foreach (int i in A)
            {
                Console.WriteLine("The sorted array is" + i);
            }
            int smallest = 1;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == smallest)
                {
                    smallest++;
                }
            }

            return smallest;
    
        }



    }
}