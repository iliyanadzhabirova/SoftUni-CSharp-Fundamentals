// See https://aka.ms/new-console-template for more information

/*On the next lines, you are going to receive some of the following:  "{name} is going!"
•	You have to add the person, if they are not on the guestlist already.
•	If the person is on the list print the following to the console: "{name} is already in the list!"
"{name} is not going!"
•	You have to remove the person, if they are on the list. 
•	If not, print out: "{name} is not in the list!"
Finally, print all of the guests, each on a new line.*/

using System.Runtime.CompilerServices;

int numberOfComand =int.Parse(Console.ReadLine());
List<string> Guestlist = new List<string>();
for (int i = 0; i < numberOfComand; i++)
{
    string []guests=Console.ReadLine().Split().ToArray();
	if (guests.Length==3)
	{
		string guestName = guests[0];
		for (int j = 0;j < Guestlist.Count; j++)
		{
			if (Guestlist[j]==guestName)
			{
				Console.WriteLine($"{guestName} is already in the list!");
				break;
			}
		}
        int counter = 0;
        for (int k = 0; k < Guestlist.Count; k++)
        {

            if (Guestlist[k] != guestName)
            {
                counter++;
            }

        }
        if (counter == Guestlist.Count)
        {
               Guestlist.Add(guestName);
        }
     
	}
	else if (guests.Length==4)
	{

        string guestName = guests[0];
		
        int counter = 0;
        for (int k = 0; k < Guestlist.Count; k++)
        {
			
            if (Guestlist[k] != guestName)
            {
				counter++;
            }

        }
		if (counter== Guestlist.Count)
		{
			Console.WriteLine($"{guestName} is not in the list!");
		}
        for (int k = 0; k < Guestlist.Count; k++)
        {
            if (Guestlist[k] == guestName)
            {
                Guestlist.Remove(guestName);
                break;
            }

        }

    }
}
for (int m = 0; m < Guestlist.Count; m++)
{
	Console.WriteLine(Guestlist[m]);

}
