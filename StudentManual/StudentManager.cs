using StudentManual.Models;

class StudentManager
{
    public void AddStudent(List<Student> students)
    {
        try
        {
            Console.Write("Enter student's name: ");
            string name = Console.ReadLine();
            Console.Write("Enter student's roll number: ");
            int rollNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter student's grade: ");
            char grade = char.Parse(Console.ReadLine());

            if (grade != 'A' && grade != 'B' && grade != 'C' && grade != 'D' && grade != 'F')
            {
                throw new ArgumentException("Invalid grade. Grade must be A, B, C, D, or F.");
            }

            Student student = new Student(name, rollNumber, grade);
            students.Add(student);
            Console.WriteLine("Student added successfully.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input format. Please enter a valid number.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void ViewAllStudents(List<Student> students)
    {
        Console.WriteLine("List of all students:");
        foreach (var student in students)
        {
            Console.WriteLine($"\nName: {student.Name}, Roll Number: {student.RollNumber}, Grade: {student.Grade}");
        }
    }

    public void SearchStudentByRollNumber(List<Student> students)
    {
        try
        {
            Console.Write("Enter student's roll number: ");
            int rollNumber = int.Parse(Console.ReadLine());

            Student student = students.Find(s => s.RollNumber == rollNumber);
            if (student != null)
            {
                Console.WriteLine($"Name: {student.Name}, Roll Number: {student.RollNumber}, Grade: {student.Grade}");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input format. Please enter a valid number.");
        }
    }

    public void UpdateStudentGrade(List<Student> students)
    {
        try
        {
            Console.Write("Enter student's roll number: ");
            int rollNumber = int.Parse(Console.ReadLine());

            Student student = students.Find(s => s.RollNumber == rollNumber);
            if (student != null)
            {
                Console.Write("Enter new grade: ");
                char newGrade = char.Parse(Console.ReadLine());

                if (newGrade != 'A' && newGrade != 'B' && newGrade != 'C' && newGrade != 'D' && newGrade != 'F')
                {
                    throw new ArgumentException("Invalid grade. Grade must be A, B, C, D, or F.");
                }

                student.UpdateGrade(newGrade);
                Console.WriteLine("Grade updated successfully.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input format. Please enter a valid number.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
