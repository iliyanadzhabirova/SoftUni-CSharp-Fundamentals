using System.Security.Authentication;

namespace _11._Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                if (input.StartsWith("exchange"))
                {
                    int index = int.Parse(input.Split().Last());
                    if (index<0||index>=array.Length)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    array=Exchange(array,index);
                }
                else if (input.StartsWith("max"))
                {
                    var condition=input.Split().Last();
                    MaxIndexForCondition(array,condition=="even");
                }
                else if (input.StartsWith("min"))
                {
                    var condition = input.Split().Last();
                    MinIndexForCondition(array, condition == "even");
                }
                else if (input.StartsWith("first"))
                {
                    string[] conditions = input.Split();
                    int count = int.Parse(conditions[1]);
                    FirstElementsForCondition(array,count,conditions.Last()=="even");
                }
                else if (input.StartsWith("last"))
                {
                    string[] conditions = input.Split();
                    int count = int.Parse(conditions[1]);
                    LastElementsForCondition(array, count, conditions.Last() == "even");
                }

            }
            Console.WriteLine("[{0}]",String.Join(", ",array));
        }

        static int[] Exchange(int[] array, int index)
        {
            return array.Skip(index+1).Take(array.Length-index).Concat(array.Take(index+1)).ToArray();
        }
        static void MaxIndexForCondition(int[] array, bool isEven)
        {
            if (!array.Any(number=>isEven==(number%2==0)))
            {
                Console.WriteLine("No matches");
            }
            else
            {
                int max=array.Where(number=>isEven==(number%2==0)).Max();
                Console.WriteLine(Array.LastIndexOf(array,max));
            }
        }
        static void MinIndexForCondition(int[] array, bool isEven)
        {
            if (!array.Any(number => isEven == (number % 2 == 0)))
            {
                Console.WriteLine("No matches");
            }
            else
            {
                int min = array.Where(number => isEven == (number % 2 == 0)).Min();
                Console.WriteLine(Array.LastIndexOf(array, min));
            }
        }

        static void FirstElementsForCondition(int[] array, int count, bool isEven)
        {
            if (count > array.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                int[] result = array.Where(number => isEven == (number % 2 == 0)).Take(count).ToArray();
                Console.WriteLine("[{0}]", string.Join(", ", result));
            }
        }
        static void LastElementsForCondition(int[] array, int count, bool isEven)
        {
            if (count > array.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                int[] result = array.Where(number => isEven == (number % 2 == 0)).TakeLast(count).ToArray();
                Console.WriteLine("[{0}]",string.Join(", ", result));
            }
        }


    }
}