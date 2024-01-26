// See https://aka.ms/new-console-template for more information


int numberOfStudents = int.Parse(Console.ReadLine());
List<Student> students = new List<Student>();
for (int i = 0; i < numberOfStudents; i++)
{
    string[] studentInfo = Console.ReadLine().Split();
    string firstName = studentInfo[0];
    string lastName = studentInfo[1];
    decimal grade = decimal.Parse(studentInfo[2]);
    Student student=new Student(firstName, lastName, grade); 
    
    students.Add(student);
}

foreach (var student in students.OrderByDescending(x=>x.Grade))
{
    Console.WriteLine(student);
}
public class Student
{
    
    public Student(string firstName, string lastName, decimal grade)
    {
        FirstName =firstName ;
        LastName = lastName;
        Grade = grade;
    }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public decimal Grade { get; set; }


    public override string ToString()
    {
        return $"{FirstName} {LastName}: {Grade:f2}";
    }
}
