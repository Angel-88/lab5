using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab5
{
    public static class StudentFileService
    {
        public static IEnumerable<Student> ReadStudentsFromFile(string fileName)
        {
            ValidateFileExisting(fileName);
            var streamReader = GetStreamReader(fileName);
            var students = ReadStudentsFromStreamReader(streamReader);
            return students;
        }

        private static void ValidateFileExisting(string fileName)
        {
            if (IsFileExistsByFileName(fileName)) return;

            Console.WriteLine("Error: File not found by filename = " + fileName);
            throw new FileNotFoundException();
        }

        private static StreamReader GetStreamReader(string fileName)
        {
            return new StreamReader(fileName, Encoding.UTF8);
        }

        private static bool IsFileExistsByFileName(string fileName)
        {
            return File.Exists(fileName);
        }

        private static IEnumerable<Student> ReadStudentsFromStreamReader(TextReader textReader)
        {
            string line;
            var result = new List<Student>();

            while ((line = textReader.ReadLine()) != null)
            {
                var studentColumns = CreateStudentFromLine(line);
                result.Add(studentColumns);
            }

            textReader.Close();
            return result;
        }

        private static Student CreateStudentFromLine(string line)
        {
            var columns = line.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            return new Student(columns);
        }
    }
}