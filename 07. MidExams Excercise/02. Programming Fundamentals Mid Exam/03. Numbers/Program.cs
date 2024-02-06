namespace _03._Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int averageNum = (int)numbers.Average();
            List<int> resultLis = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i]>averageNum)
                {
                    resultLis.Add(numbers[i]); 
                }
            }
            if (resultLis.Count==0)
            {
                Console.WriteLine("No");
            }
            List<int> orderedList=resultLis.OrderByDescending(x => x).ToList();
            if (resultLis.Count>=5)
            {
                
                Console.WriteLine(string.Join(" ", orderedList.Take(5)));
            }
            if (orderedList.Count<5)
            {
                Console.WriteLine(string.Join(" ", orderedList));
            }
           
        }
    }
}