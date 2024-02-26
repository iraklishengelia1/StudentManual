namespace StudentManual.Models
{
    public class Student
    {
        public string Name { get; private set; }
        public int RollNumber { get; private set; }
        public char Grade { get;  private set; }
        public Student(string name, int rollNumber, char grade)
        {
            Name = name;
            RollNumber = rollNumber;
            Grade = grade;
        }
        public void UpdateGrade(char newGrade)
        {
            if (newGrade == 'A' || newGrade == 'B' || newGrade == 'C' || newGrade == 'D' || newGrade == 'F')
            {
                Grade = newGrade;
            }
            else
            {
                Console.WriteLine("Invalid grade. Grade must be A, B, C, D, or F.");
            }
        }

        public override string ToString()
        {
            return $"Name: {Name}, Roll Number: {RollNumber}, Grade: {Grade}";
        }

    }



}
