namespace _09._Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers= new List<int> { 1, 2, 3, 4, 5, 6, 6 };

            List<int> oddNumbers= numbers.Where(x=> x % 2 != 0).ToList();//1 3 5
            List<int> evenNumbers = numbers.Where(x => x % 2 == 0).ToList();//2 4 6
            List<int> biggerThan=numbers.Where(x=> x > 4).ToList();//5 6

            List<int>orderByAscending=numbers.OrderBy(x=>x).ToList();//1 2 3 4 5 6
            List<int> orderByDescending = numbers.OrderByDescending(x => x).ToList();//6 5 4 3 2 1

            bool any=numbers.Any(x=>x==1);//true
            bool all = numbers.All(x => x > 0);//true

            int indexOfElement=numbers.IndexOf(6);//5
            int lastIndexOf=numbers.LastIndexOf(6);//6

            List<int> ints = new List<int> { 10, 20, };
            numbers.AddRange(ints);

            List<int> multiplyNumbers=numbers.Select(x=>x*2).ToList();

            int min=numbers.Min();//1
            int max = numbers.Max();//6
            double average=numbers.Average(); 

            double sum=numbers.Sum();//27

            List<int>skip=numbers.Skip(5).ToList();
            List<int> take = numbers.Take(2).ToList();

            numbers.RemoveAll(x=>x>0);

            numbers.Clear();
            //static List<int>MyWhere(List<int> numbers)
            //{
            //    List<int> nums = new List<int>();

            //    foreach (int item in numbers)
            //    {
            //        if (item%2==0)
            //        {
            //            nums.Add(item);
            //        }
            //    }
            //    return nums;
            //}
            //List<string> names = new List<string>();

            //  names.Add("A");//A->[0]
            //  names.Add("B");//B->[1]

            //  bool isRemoved=names.Remove("A");//true
            //  bool isRemoved2=names.Remove("K");//false

            //  Console.WriteLine(names.Count);//1

            //  names.Insert(1, "S");
            //  names.RemoveAt(1);

            //  int indexOfElement=names.IndexOf("S");

            //  names.Sort();

            //  Console.WriteLine(string.Join(" ",names));
        }
    }
}