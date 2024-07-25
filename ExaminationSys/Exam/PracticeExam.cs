using ExamComponents;
using System;

namespace Exam
{
    public class PracticeExam : Exam
    {
        public PracticeExam(uint numOfQ) : base(numOfQ)
        {
        }

        internal PracticeExam(Subject sub, TimeSpan time, uint numOfQ)
            : base(sub, time, numOfQ)
        {
        }

        public override void ShowExam()
        {
            Console.WriteLine(Subject);
            Console.WriteLine("========================================================");
            for (int i = 0; i < NumberOfQ; i++)
            {
                Console.WriteLine($"({i + 1}) {Questions.List[i]}");
                Console.WriteLine(Answers.List[i]);
                Console.WriteLine();
                Console.WriteLine();
            }

            Console.WriteLine("========================================================");
            Console.WriteLine("Exam Answers");
            Console.WriteLine("--------------");
            Console.WriteLine();


            for(int j = 0; j < NumberOfQ; j++)
            {
                if(Answers.List[j].GetType().Name == "TorFAnswer")
                {
                    TorFAnswer right = (TorFAnswer)Answers.List[j];
                    Console.WriteLine($"({j + 1}) {right.QAnswer}");
                }
                else if (Answers.List[j].GetType().Name == "ChooseOneAnswer")
                {
                    ChooseOneAnswer right = (ChooseOneAnswer)Answers.List[j];
                    Console.WriteLine($"({j + 1}) {right.RightAns}");
                }
                else
                {
                    MultiChoicesAnswers right = (MultiChoicesAnswers)Answers.List[j];
                    Console.WriteLine($"({j + 1}) {right.RightAns}");
                }
            }
        }
    }
}
