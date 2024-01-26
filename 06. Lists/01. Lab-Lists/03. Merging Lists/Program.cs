namespace _03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int>list1=Console.ReadLine().Split().Select(int.Parse).ToList();
           List<int> list2 = Console.ReadLine().Split().Select(int.Parse).ToList();
           List<int>resultList= new List<int>();

            int minValue=Math.Min(list1.Count, list2.Count);

            for (int i = 0;i < minValue; i++)
            {
                resultList.Add(list1[i]);
                resultList.Add(list2[i]);

            }
            if (list1.Count>list2.Count)
            {
                for (int i = minValue; i < list1.Count; i++)
                {
                    resultList.Add(list1[i]);
                }
            }
            else if(list2.Count > list1.Count)
            {

                for (int i = minValue; i < list2.Count; i++)
                {
                    resultList.Add(list2[i]);
                }
            }
            Console.WriteLine(String.Join(" ",resultList));
        }
    }
}