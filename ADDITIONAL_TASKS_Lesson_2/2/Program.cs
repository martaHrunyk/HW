public struct Student
{
    public string LastName;
    public int GroupNumber;
}
class Program
{
    static void Main()
    {
        Console.Write("Enter the number of students: ");
        int numberOfStudents = int.Parse(Console.ReadLine());
        Student[] students = new Student[numberOfStudents];
        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.Write($"Enter last name for student {i + 1}: ");
            students[i].LastName = Console.ReadLine();
            Console.Write($"Enter group number for student {i + 1}: ");
            students[i].GroupNumber = int.Parse(Console.ReadLine());
        }
         Console.Write("Enter the Group №: ");
            int targetGroup = int.Parse(Console.ReadLine());
            Console.Write("Enter the starting letter of last names: ");
            char startingLetter = char.Parse(Console.ReadLine());
            Console.WriteLine($"Students in group {targetGroup} with last names starting with {startingLetter}:");
            foreach (var student in students)
            {
                if (student.GroupNumber == targetGroup && student.LastName.StartsWith(startingLetter.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(student.LastName);
                }
            }
        

    }
}


