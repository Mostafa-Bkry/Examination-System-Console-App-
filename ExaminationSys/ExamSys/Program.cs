using Exam;
using ExamComponents;

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

            FinalExam final = new FinalExam(numOfQ);
            final.CreateExam();

            //PracticeExam practice = new PracticeExam(numOfQ);
            //practice.CreateExam();
        }
    }
}
