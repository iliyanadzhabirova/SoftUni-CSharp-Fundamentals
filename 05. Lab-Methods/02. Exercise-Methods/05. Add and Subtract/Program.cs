namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int FirstResult = GetResulOne(firstNum, secondNum);
            int FinalResult = GetResultTwo(FirstResult, thirdNum);

            Console.WriteLine(FinalResult);
        }
        static int GetResulOne(int firstNum, int secondNum)
        {
            int operationOne = firstNum + secondNum;
            return operationOne;
        }
        static int GetResultTwo(int resultOne,int thirdNum)
        {
            int operationTwo= resultOne - thirdNum;
            return operationTwo;
        }
    }
}