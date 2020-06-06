using System;
using System.Collections.Generic;

namespace Lab5
{
    public static class StudentService
    {
        public static void PrintStudents(IEnumerable<Student> students)
        {
            foreach (var s in students)
            {
                Console.WriteLine(
                    "Last name: " + s.lastName + ", " +
                    "First name: " + s.firstName + ", " +
                    "Patronymic: " + s.patronymic + ", " +
                    "Physics mark: " + s.physicsMark
                );
            }
        }

        public static IEnumerable<Student> FilterStudents(IEnumerable<Student> studentsWithAverageMarks)
        {
            var result = new List<Student>();

            foreach (var student in studentsWithAverageMarks)
            {
                var averageMarks = CalculateAverageMark(student);
                if (averageMarks > 4.5) result.Add(student);
            }

            return result;
        }

        private static double CalculateAverageMark(Student student)
        {
            var mathematics = ProcessMark(student.mathematicsMark);
            var physics = ProcessMark(student.physicsMark);
            var informatics = ProcessMark(student.informaticsMark);
            return (mathematics + physics + informatics) / 3;
        }

        private static double ProcessMark(char mark)
        {
            var markString = mark.ToString();
            if (markString == "-") return 0;
            return double.Parse(markString);
        }
    }
}