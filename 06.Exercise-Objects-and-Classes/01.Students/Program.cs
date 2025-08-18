
internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        List<Student> students = new List<Student>();

        for (int i = 0; i < n; i++)
        {
            string[] studentData = Console.ReadLine().Split(" ");

            string firstName = studentData[0];
            string lastName = studentData[1];
            double grade = double.Parse(studentData[2]);

            Student currentStudent = new Student(firstName, lastName, grade);

            students.Add(currentStudent);
        }

        foreach (Student item in students.OrderByDescending(s => s.Grade))
        {
            Console.WriteLine($"{item.FirstName} {item.LastName}: {item.Grade:F2}");
        }
    }
}

public class Student
{
    public Student(string firstName, string lastName, double grade)
    {
        FirstName = firstName;
        LastName = lastName;
        Grade = grade;
    }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public double Grade { get; set; }
}