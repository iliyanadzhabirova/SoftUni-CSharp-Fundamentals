Dictionary<string,string>parking=new Dictionary<string,string>();

int n=int.Parse(Console.ReadLine());

for(int i = 0; i < n; i++)
{
    string[] userInfo=Console.ReadLine().Split();
    string command = userInfo[0];
    string user = userInfo[1];
   

    if (command=="register")
    {
        string carNumber = userInfo[2];
        if (!parking.ContainsKey(user))
        {
            parking.Add(user, carNumber);
            Console.WriteLine($"{user} registered {carNumber} successfully");
        }
        else
        {
            Console.WriteLine($"ERROR: already registered with plate number {carNumber}");
        }
    }
    else
    {
        if (parking.ContainsKey(user))
        {
            parking.Remove(user);
            Console.WriteLine($"{user} unregistered successfully");
        }
        else
        {
            Console.WriteLine($"ERROR: user {user} not found");
        }
    }

}
foreach (var kvp in parking)
{
    Console.WriteLine($"{kvp.Key} => {kvp.Value}");
}
