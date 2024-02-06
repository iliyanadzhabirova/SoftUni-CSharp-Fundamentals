int n = int.Parse(Console.ReadLine());

int totalBoxes = 0;
for (int i = 0; i < n; i++)
{
    int flour = int.Parse(Console.ReadLine());
    int sugar = int.Parse(Console.ReadLine());
    int cocoa = int.Parse(Console.ReadLine());


    int totalCookiesPerBake = (140 + 10 + 20) * new[] { flour / 140, sugar / 20, cocoa / 10 }.Min() / 25;
    if (totalCookiesPerBake <= 0)
    {
        Console.WriteLine("Ingredients are not enough for a box of cookies.");

    }
    else
    {
        int boxesPerBatch = totalCookiesPerBake / 5;
        totalBoxes += boxesPerBatch;
      

        Console.WriteLine($"Boxes of cookies: {boxesPerBatch}");
    }

}
Console.WriteLine($"Total boxes: {totalBoxes}");

