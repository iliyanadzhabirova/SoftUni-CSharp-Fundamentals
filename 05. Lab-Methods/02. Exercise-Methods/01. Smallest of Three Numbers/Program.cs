namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first=int.Parse(Console.ReadLine());
            int second=int.Parse(Console.ReadLine());
            int third=int.Parse(Console.ReadLine());

            GetTheSmallest(first,second,third);
        }
        static void GetTheSmallest(int a, int b, int c)
        {
           if (a <= b && a<=c)
            {
                Console.WriteLine(a);
            }

            else if (b <= c && b <= a)
            {
                Console.WriteLine(b);
            }

            else if (c <= b && c <= a)
            {
                Console.WriteLine(c);
            }

        }
    }
}