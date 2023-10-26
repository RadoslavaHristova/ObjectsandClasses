namespace _04.StudentsExercise
{
    internal class Program
    {
        public class Students
        {
            public Students(string firstName,string secondName,string grade) 
            {
                FirstName = firstName;
                LastName = secondName;
                Grade = grade;
            }
            public string FirstName;
            public string LastName;
            public string Grade;
            public override string ToString()
            {
                return $"{FirstName} {LastName}: {Grade}";
            }
        }
        static void Main(string[] args)
        {
            List<Students> students = new List<Students>();

            int studentsCount =int.Parse(Console.ReadLine());

            for (int i = 0; i < studentsCount; i++) 
            {
                string[] tokens = Console.ReadLine().Split();

                string firstName = tokens[0];
                string secondName = tokens[1];
                string grade = tokens[2];

                Students student=new Students(firstName, secondName, grade);

                students.Add(student);
            }
             students=students.OrderByDescending(s => s.Grade).ToList();

            Console.WriteLine(string.Join("\n", students));
        }
    }
}