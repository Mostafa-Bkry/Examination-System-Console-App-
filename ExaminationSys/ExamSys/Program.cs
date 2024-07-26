using ExamTypes;
using ExamComponents;
using TeachAndSt;

namespace ExamSys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? input;
            uint numOfQ;

            do
            {
                Console.WriteLine("Enter Number of Exam Questions");
                input = Console.ReadLine();
            }
            while (string.IsNullOrEmpty(input) || !uint.TryParse(input, out numOfQ) || numOfQ == 0);

            ExamTypeEnum examType;
            do
            {
                Console.WriteLine("Enter Exam Type");
                Console.WriteLine("1 --> Practice Exam\t2 --> Final Exam");
                input = Console.ReadLine();
            }
            while (string.IsNullOrEmpty(input) || (input != "1" && input != "2"));

            examType = (ExamTypeEnum)Enum.Parse(typeof(ExamTypeEnum), input);

            //--------------------------
            Teacher t1 = new Teacher();

            t1.AddExam(examType, numOfQ);

            //Console.Clear();

            //t1.AddExam(examType, numOfQ);

            t1.ShowMyExams();
            //--------------------------
            Console.ReadLine();
            Console.Clear();
            //--------------------------
            Student s1 = new Student(t1);

            s1.TakeExam();
        }
    }
}
