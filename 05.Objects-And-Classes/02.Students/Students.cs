namespace Students
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Student> studentsList = new List<Student>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] studentData = input.Split(" ");

                string firstName = studentData[0];      
                string lastName = studentData[1];       
                int age = int.Parse(studentData[2]);    
                string town = studentData[3];           

                Student student = new Student(firstName, lastName, age, town);

                studentsList.Add(student);


                input = Console.ReadLine();
            }


            string searchedCity = Console.ReadLine(); 

            foreach (Student student in studentsList)
            {
                if (student.Hometown == searchedCity)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }
}