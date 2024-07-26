using ExamTypes;

namespace TeachAndSt
{
    public enum ExamTypeEnum : byte
    {
        Practice = 1, Final = 2,
        practice = 1, final = 2,
        P = 1, F = 2,
        p = 1, f = 2
    }

    public class Teacher
    {
        Exam exam;
        Dictionary<Subject, Exam> teacherExams;

        public Teacher()
        {
            teacherExams = new Dictionary<Subject, Exam>();
        }

        public Exam Exam { get => exam; }
        public Dictionary<Subject, Exam> TeacherExams { get => teacherExams; }

        public void AddExam(ExamTypeEnum examType, uint numOfQ)
        {
            if (examType == ExamTypeEnum.Practice)
                exam = new PracticeExam(numOfQ);
            else if (examType == ExamTypeEnum.Final)
                exam = new FinalExam(numOfQ);

            exam.CreateExam();
            teacherExams.Add(exam.Subject, exam);
        }

        public void ShowMyExams()
        {
            if(teacherExams.Count > 0)
            {
                foreach (var e in TeacherExams)
                {
                    Console.Clear();
                    e.Value.ShowExam();
                    Console.WriteLine();
                    Console.WriteLine("#############################################################");
                    Console.WriteLine();
                }
            }
        }
    }
}
