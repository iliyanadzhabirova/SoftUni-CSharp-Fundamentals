namespace Problem_1___Guinea_Pig
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float foodPerMonth = float.Parse(Console.ReadLine())*1000;
            float hayPerMonth = float.Parse(Console.ReadLine())*1000;
            float coverPerMonth = float.Parse(Console.ReadLine()) * 1000;
            float weight = float.Parse(Console.ReadLine()) * 1000;

            float foodPerDay = 300;
            
            float coverPerDay = weight / 3;


            for (int i = 1; i <= 30; i++)
            {
                foodPerMonth=foodPerMonth-foodPerDay;

                if (i % 2 == 0)
                {
                    float hayPerDay = (float)0.05 * foodPerMonth;
                    hayPerMonth =hayPerMonth- hayPerDay;
                }
                if (i % 3 == 0)
                {
                    coverPerMonth =coverPerMonth- coverPerDay;
                }
                if (foodPerMonth <= 0 || hayPerMonth <= 0 || coverPerMonth <= 0)
                {
                    Console.WriteLine("Merry must go to the pet store!");
                    return;
                }
            }
            Console.WriteLine($"Everything is fine! Puppy is happy! Food: {foodPerMonth / 1000:f2}, Hay: {hayPerMonth / 1000:f2}, Cover: {coverPerMonth / 1000:f2}.");

        }
    }
}