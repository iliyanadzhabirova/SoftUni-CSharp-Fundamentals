Dictionary<string, double[]> orders = new Dictionary<string, double[]>();

string input=Console.ReadLine();

while (input != "buy")
{
    string[] productInfo = input.Split();

    string product = productInfo[0];
    double price = double.Parse(productInfo[1]);
    int quantity = int.Parse(productInfo[2]);
    if (!orders.ContainsKey(product))
    {
        orders[product] = new double[2] ;
    }
    orders[product][0] = price;
    orders[product][1] += quantity;


    input = Console.ReadLine();
}
foreach (var kvp in orders)
{
double totalPrice = kvp.Value[0] * kvp.Value[1];
    Console.WriteLine($"{kvp.Key} -> {totalPrice:f2}");
}