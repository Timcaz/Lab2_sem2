namespace Lab2_sem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = GetStudentsFromFile("StudentsGrade.csv");
            List<Student> filteredStudents = students.Where(s => (s.Grade1 + s.Grade2) / 2.0 > 60).ToList();

            for (int i = 0; i < filteredStudents.Count; i++)
            {
                Console.WriteLine("{0} {1}: {2}", filteredStudents[i].FirstName, filteredStudents[i].LastName, (filteredStudents[i].Grade1 + filteredStudents[i].Grade2) / 2.0);
            }

            static List<Student> GetStudentsFromFile(string filePath)
            {
                if (!File.Exists(filePath)) { return null; }
                List<Student> students = new List<Student>();
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line = reader.ReadLine();
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        Student student = new Student
                        {
                            FirstName = parts[0].Trim(),
                            LastName = parts[1].Trim(),
                            Grade1 = int.Parse(parts[2]),
                            Grade2 = int.Parse(parts[3])
                        };
                        students.Add(student);
                    }
                }

                return students;
            }
        }
    }
}