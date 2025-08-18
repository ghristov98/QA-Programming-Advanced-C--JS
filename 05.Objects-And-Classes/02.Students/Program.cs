namespace Students
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Hometown { get; set; }

        public Student()
        {
        }

        public Student(string firstName, string lastName, int age, string hometown)
        {

            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Hometown = hometown;
        }
    }
}