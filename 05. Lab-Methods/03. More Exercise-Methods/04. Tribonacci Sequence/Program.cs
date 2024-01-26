using System;
using System.Numerics;

namespace _04._Tribonacci_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            array[0] = 1;
            for (int i = 1; i < n; i++)
            {
                if (i == 1)
                {
                    array[i] = i;
                }
                else if (i == 2)
                {
                    array[i] = i;
                }
                else
                {
                    array[i] = array[i - 1] + array[i - 2] + array[i - 3];
                }
            }
            Console.WriteLine(String.Join(" ", array));
        }

     
      
    }
}