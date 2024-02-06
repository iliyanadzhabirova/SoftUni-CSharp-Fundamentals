using System;

namespace Basic_Syntax__CS_and_Loops_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int studentAge = int.Parse(Console.ReadLine());
            double studentGrade = double.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {studentName}, Age: {studentAge}, Grade: { studentGrade:F2}");
        }
    }
}
