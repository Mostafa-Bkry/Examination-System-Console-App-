using ExamTypes;
using System;

namespace TeachAndSt
{
    public class Student
    {
        Teacher teacher;
        public Student(Teacher t)
        {
            teacher = t;
        }

        public void TakeExam()
        {
            List<string> subs = new List<string>();
            uint counter = 1;

            foreach (var exam in teacher.TeacherExams)
            {
                subs.Add($"{counter}");
                Console.WriteLine($"({counter})");
                Console.WriteLine(exam.Key);
                Console.WriteLine("---------------------------------------------------------");
                counter++;
            }

            Console.WriteLine();
            string? input;

            do
            {
                Console.WriteLine("Choose One Subject by its number");
                input = Console.ReadLine();
            }
            while (string.IsNullOrEmpty(input) || !subs.Contains(input));

            uint choosen = uint.Parse(input);

            counter = 1;
            foreach (var e in teacher.TeacherExams)
            {
                if(choosen == counter)
                {
                    Console.Clear();
                    e.Value.ShowExam();
                    Console.ReadLine();
                    break;
                }
                counter++;
            }
        }
    }
}
