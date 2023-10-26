namespace _05.Students2._0
{
    internal class Program
    {
        public class Students
        {
            public Students(string firstName, string lastName, int age, string homeTown)
            {
                FirstName = firstName;
                LastName = lastName;
                Age = age;
                HomeTown = homeTown;
            }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string HomeTown { get; set; }
        }
        static void Main(string[] args)
        {
            List<Students> studentsList = new List<Students>();

            string command = "";
            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split();

                string firstName = arguments[0];
                string lastName = arguments[1];
                int age = int.Parse(arguments[2]);
                string homeTown = arguments[3];

                

                Students student = studentsList.FirstOrDefault(student => student.FirstName == firstName && student.LastName == lastName);

                if(student==null)
                {
                     
                    studentsList.Add(new Students(firstName,lastName,age,homeTown));
                }

                else
                {
                    student.Age = age;
                    student.HomeTown = homeTown;
                }
            }
            string city = Console.ReadLine();

            foreach (Students student in studentsList)
            {
                if (student.HomeTown == city)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }

        }
    }
}