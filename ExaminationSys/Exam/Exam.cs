using ExamComponents;

namespace ExamTypes
{
    public abstract class Exam
    {
        Subject subject;
        TimeSpan examTime;
        uint numberOfQ;
        //QuestionType questionType;
        QuestionsList questions;
        AnswersList answers;
        //Dictionary<Question, Answer> qAns;

        protected Exam(uint numOfQ) 
            : this(new Subject("","","",1), TimeSpan.FromSeconds(1), numOfQ)
        { }

        protected Exam(Subject sub, TimeSpan time, uint numOfQ/*, QuestionsList qList, AnswersList aList*/)
        {
            subject = sub;
            examTime = time;
            numberOfQ = numOfQ;
            //questions = qList;
            //answers = aList;
            //qAns = new Dictionary<Question, Answer>();
            questions = new QuestionsList();
            answers = new AnswersList();
        }

        public Subject Subject { get => subject; }
        public TimeSpan ExamTime { get => examTime; }
        public uint NumberOfQ { get => numberOfQ; }
        public QuestionsList Questions { get => questions; }
        public AnswersList Answers { get => answers; }

        public void CreateExam()
        {
            subject = ExamCreater.EnterExamSubjectHeader();

            examTime = ExamCreater.EnterExamTime();
            Console.WriteLine("========================================================");
            Console.WriteLine();

            uint markForEach = subject.FullMark / numberOfQ;
            QuestionType qType;

            for(int i = 0; i < numberOfQ; i++)
            {
                Console.WriteLine($"Q({i + 1})");
                questions.Add = ExamCreater.EnterQuestion(markForEach, out qType);
                answers.Add = ExamCreater.EnterQAnswer(qType);
                Console.WriteLine("-----------------------------");
            }
            Console.WriteLine();
            Console.WriteLine("#############################################################");
            Console.WriteLine();
        }
        public abstract void ShowExam();
    }
}
