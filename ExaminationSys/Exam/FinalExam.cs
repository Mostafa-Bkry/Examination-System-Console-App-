using ExamComponents;
using System;

namespace Exam
{
    public class FinalExam : Exam
    {
        public FinalExam(uint numOfQ) : base(numOfQ)
        { }
        public FinalExam(Subject sub, TimeSpan time, uint numOfQ) 
            : base(sub, time, numOfQ)
        {
        }

        public override void ShowExam()
        {
            Console.WriteLine(Subject);
            Console.WriteLine("========================================================");
        }
    }
}
