using System;

namespace Lab5
{
    internal static class Program
    {
        private static void Main()
        {
            var students = StudentFileService.ReadStudentsFromFile("input.txt");
            var filteredStudents = StudentService.FilterStudents(students);
            StudentService.PrintStudents(filteredStudents);

            Console.ReadKey();
        }
    }
}