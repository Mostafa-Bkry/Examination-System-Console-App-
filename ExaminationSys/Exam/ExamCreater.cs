using ExamComponents;

namespace Exam
{
    public static class ExamCreater
    {
        #region Subject Section
        public static Subject EnterExamSubjectHeader()
        {
            string? input;


            string subName, profName, deptName;
            uint fullMark;

            do
            {
                Console.WriteLine("Enter Subject Name");
                input = Console.ReadLine();
            }
            while (string.IsNullOrEmpty(input));
            subName = input;

            do
            {
                Console.WriteLine("Enter Professor Name");
                input = Console.ReadLine();
            }
            while (string.IsNullOrEmpty(input));
            profName = input;

            do
            {
                Console.WriteLine("Enter Department Name");
                input = Console.ReadLine();
            }
            while (string.IsNullOrEmpty(input));
            deptName = input;

            do
            {
                Console.WriteLine("Enter Full Mark");
                input = Console.ReadLine();
            }
            while (string.IsNullOrEmpty(input) || !uint.TryParse(input, out fullMark) || fullMark == 0);

            return new Subject(subName, profName, deptName, fullMark);
        }
        #endregion

        #region Time Section
        public static TimeSpan EnterExamTime()
        {
            string? input;


            uint h;
            do
            {
                Console.WriteLine("Enter Exam Hours");
                input = Console.ReadLine();
            }
            while (string.IsNullOrEmpty(input) || !uint.TryParse(input, out h) || h == 0);


            return TimeSpan.FromHours(h);
        }
        #endregion

        #region Question Sections
        public static Question EnterQuestion(uint markForEach)
        {
            string? input;
            QuestionType qType;

            #region Question Type Input
            do
            {
                Console.WriteLine("Enter Question Type Number");
                Console.WriteLine("1 --> True or False\t2 --> Choose One\t3 --> Multi Choices");
                input = Console.ReadLine();
            }
            while (string.IsNullOrEmpty(input) || (input != "1" && input != "2" && input != "3"));
            #endregion

            qType = (QuestionType)Enum.Parse(typeof(QuestionType), input);

            switch (qType)
            {
                #region TrueOrFalse
                case QuestionType.TrueOrFalse:
                    do
                    {
                        Console.WriteLine("Enter Question Body");
                        input = Console.ReadLine();
                    }
                    while (string.IsNullOrEmpty(input));

                    return new TrueOrFalse(input, markForEach);
                #endregion

                #region ChooseOne
                case QuestionType.ChooseOne:
                    do
                    {
                        Console.WriteLine("Enter Question Body");
                        input = Console.ReadLine();
                    }
                    while (string.IsNullOrEmpty(input));

                    return new ChooseOne(input, markForEach);
                #endregion

                #region MultiChoices
                case QuestionType.MultiChoices:
                    do
                    {
                        Console.WriteLine("Enter Question Body");
                        input = Console.ReadLine();
                    }
                    while (string.IsNullOrEmpty(input));

                    return new MultiChoices(input, markForEach);
                #endregion

                default:
                    return null;
            }
        }
        #endregion

        #region Answer Section

        #endregion
    }
}
