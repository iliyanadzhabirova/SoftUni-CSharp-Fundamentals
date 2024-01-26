namespace _04._List_of_Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            List<string>ListOfProducts= new List<string>();
            for (int i = 0; i < n; i++)
            {
                string product = Console.ReadLine();
                ListOfProducts.Add(product);
            }
            ListOfProducts.Sort();
            for (int i = 0; i < ListOfProducts.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{ListOfProducts[i]}");
            }
            
        }
    }
}