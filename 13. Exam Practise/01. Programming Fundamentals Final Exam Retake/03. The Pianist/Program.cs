Dictionary<string,List<string>>pianoPieces = new Dictionary<string,List<string>>();

int n=int.Parse(Console.ReadLine());
for(int i = 0; i < n; i++)
{
    string[]pieces=Console.ReadLine().Split("|",StringSplitOptions.RemoveEmptyEntries);
    string piece = pieces[0];
    string composer = pieces[1];
    string key = pieces[2];

    if(!pianoPieces.ContainsKey(piece))
    {
        pianoPieces.Add(piece, new List<string>());
        pianoPieces[piece].Add(composer);
        pianoPieces[piece].Add(key);
    }
    
}
string input=Console.ReadLine();    

while(input!= "Stop")
{
    string[] commandsArgs = input.Split("|", StringSplitOptions.RemoveEmptyEntries);
    string command = commandsArgs[0];
    string piece= commandsArgs[1];
    if (command== "Add")
    {
        if (pianoPieces.ContainsKey(piece))
        {
            Console.WriteLine($"{piece} is already in the collection!");
        }
        else
        {
            string composer = commandsArgs[2];
            string key = commandsArgs[3];
            pianoPieces.Add(piece,new List<string>());
            pianoPieces[piece].Add (composer);
            pianoPieces[piece].Add(key) ;
            Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
        }
    }
    else if(command== "Remove")
    {
        if (pianoPieces.ContainsKey(piece))
        {
            pianoPieces.Remove(piece);
            Console.WriteLine($"Successfully removed {piece}!");
        }
        else
        {
            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
        }
    }
    else if(command== "ChangeKey")
    {
        string newKey = commandsArgs[2];
        
        if (pianoPieces.ContainsKey(piece))
        {

            pianoPieces[piece][1] = newKey;
            Console.WriteLine($"Changed the key of {piece} to {newKey}!");
        }
        else
        {
            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
        }
       
    }

    input= Console.ReadLine();
}
foreach (var piece in pianoPieces)
{
    Console.WriteLine($"{piece.Key} -> Composer: {piece.Value[0]}, Key: {piece.Value[1]}");
}