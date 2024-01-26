using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            
            
           
            for (int i = 1; i <= number; i++)
            {
               
                int sum = 0;
                int currentNum = i;
                while (currentNum > 0)
                {
                    sum += currentNum % 10;
                    currentNum/= 10;
                }
                currentNum = i;
                bool trueOrFalse = false;
                trueOrFalse = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", currentNum, trueOrFalse);
              
            }


        }
    }
}
