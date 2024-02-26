using StudentManual.Models;

List<Student> students = new List<Student>
            {
                new Student("John Doe", 1, 'A'),
                new Student("Jane Smith", 2, 'B'),
                new Student("Alice Johnson", 3, 'C'),
                new Student("Bob Brown", 4, 'D'),
                new Student("Eve Williams", 5, 'F')
            };

StudentManager studentManager = new StudentManager();

while (true)
{
    Console.WriteLine("Student Management System");
    Console.WriteLine("1. Add a new student");
    Console.WriteLine("2. View all students");
    Console.WriteLine("3. Search for a student by roll number");
    Console.WriteLine("4. Update a student's grade");
    Console.WriteLine("5. Exit");
    Console.Write("Enter your choice: ");
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            studentManager.AddStudent(students);
            break;
        case 2:
            studentManager.ViewAllStudents(students);
            break;
        case 3:
            studentManager.SearchStudentByRollNumber(students);
            break;
        case 4:
            studentManager.UpdateStudentGrade(students);
            break;
        case 5:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
}
        