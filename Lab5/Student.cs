using System;
using System.Collections.Generic;

namespace Lab5
{
    public readonly struct Student
    {
        public readonly string lastName;
        public readonly string firstName;
        public readonly string patronymic;
        public readonly char sex;
        public readonly string dateOfBirth;
        public readonly char mathematicsMark;
        public readonly char physicsMark;
        public readonly char informaticsMark;
        public readonly int scholarship;

        public Student(IReadOnlyList<string> data)
        {
            lastName = data[0];
            firstName = data[1];
            patronymic = data[2];
            sex = Convert.ToChar(data[3]);
            dateOfBirth = data[4];
            mathematicsMark = Convert.ToChar(data[5]);
            physicsMark = Convert.ToChar(data[6]);
            informaticsMark = Char.Parse(data[7]);
            scholarship = int.Parse(data[8]);
        }
    }
}