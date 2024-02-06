using System.Numerics;
using System.Xml.Linq;

namespace _02._Array_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {

//•	"multiply {index1} {index2}" takes element at the 1st index and multiply it with the element at 2nd index. Save the product at the 1st index.
//•	"decrease" decreases all elements in the array with 1.
            int[] numbers=Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string command=Console.ReadLine();

            while (command!="end")
            {
                string[] action = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (action[0]=="swap")
                {
                    int indexSwapOne = int.Parse(action[1]);
                    int indexSwapTwo= int.Parse(action[2]);

                    int t = numbers[indexSwapOne];
                    numbers[indexSwapOne] = numbers[indexSwapTwo];
                    numbers[indexSwapTwo] = t;

                }
                else if (action[0]=="multiply")
                {
                    int firstIndex= int.Parse(action[1]);
                    int secondIndex = int.Parse(action[2]);
                    numbers[firstIndex] = numbers[secondIndex] * numbers[firstIndex];
                }
                else if (action[0]=="decrease")
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] -= 1;
                    }
                }


                command= Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ",numbers));

        }
    }
}