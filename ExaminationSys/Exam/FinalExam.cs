using ExamComponents;
using System;

namespace Exam
{
    public class FinalExam : Exam
    {
        public FinalExam(uint numOfQ) : base(numOfQ)
        { }
        internal FinalExam(Subject sub, TimeSpan time, uint numOfQ) 
            : base(sub, time, numOfQ)
        {
        }

        public override void ShowExam()
        {
            Console.WriteLine(Subject);
            Console.WriteLine("========================================================");
            for(int i = 0; i < NumberOfQ; i++)
            {
                Console.WriteLine($"({i + 1}) {Questions.List[i]}");
                Console.WriteLine(Answers.List[i]);
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
