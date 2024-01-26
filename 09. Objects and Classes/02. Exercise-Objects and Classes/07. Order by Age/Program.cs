// See https://aka.ms/new-console-template for more information

List<Person> people = new List<Person>();
string input=Console.ReadLine();
while (input!="End")
{ 
    string[] personInfo = input.Split();
    string firstName = personInfo[0];
    string iD = personInfo[1];
    int age = int.Parse(personInfo[2]);
    Person person = new Person(firstName, iD, age);

    if (people.Any(t => t.Id == iD))
    {
        person.FirstName = firstName;
        person.Age = age;
    }
    
    people.Add(person);
    input = Console.ReadLine();
}

  

foreach (var person in people.OrderBy(x => x.Age))
{
    Console.WriteLine(person);
}

public class Person
{

    public Person(string firstName, string iD, int age)
    {
        FirstName = firstName;
        Id = iD;
        Age = age;
    }
    public string FirstName { get; set; }
    public string Id { get; set; }
    public int Age { get; set; }


    public override string ToString()
    {
        return $"{FirstName} with ID: {Id} is {Age} years old.";
    }
}

