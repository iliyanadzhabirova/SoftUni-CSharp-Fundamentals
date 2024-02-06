// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;

List<Student> students = new List<Student>();
string info = Console.ReadLine();
while (info != "end")
{
    string[] infoArray = info.Split();

    string firstName = infoArray[0];
    string lastName = infoArray[1];
    int age = int.Parse(infoArray[2]);
    string town = infoArray[3];

    bool studentExists = false;

    foreach (var student in students)
    {
        if (student.FirstName==firstName && student.LastName==lastName)
        {
            student.Age = age;
            student.HomeTown = town;
            studentExists = true;
            break;
        }
    }
    //Student currentStudent = students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName) ;// Student || null
    // if(currentStudent!=null)
    //{
    //    currentStudent.Age = age;
    //    currentStudent.HomeTown = town;
    //}
    //studentExists=studentAny(x => x.FirstName == firstName && x.LastName=lastName);
    if (!studentExists) 
    {
        Student student = new Student
        {
            FirstName = firstName,
            LastName = lastName,
            Age = age,
            HomeTown = town

        };
        students.Add(student);
    }
   
    info = Console.ReadLine();
}
string homeTown = Console.ReadLine();

foreach (Student currentStudent in students)
{
    if (currentStudent.HomeTown == homeTown)
    {
        Console.WriteLine($"{currentStudent.FirstName} {currentStudent.LastName} is {currentStudent.Age} years old.");
    }
}




class Student
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public int Age { get; set; }

    public string HomeTown { get; set; }
}


