using ExamComponents;

namespace ExamTypes
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
        public static Question EnterQuestion(uint markForEach, out QuestionType qType)
        {
            string? input;
            //QuestionType qType;

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
        public static Answer EnterQAnswer(QuestionType qType)
        {
            string? input;

            switch (qType)
            {
                #region TrueOrFalse
                case QuestionType.TrueOrFalse:
                    byte ans;

                    do
                    {
                        Console.WriteLine("Enter The Right Answer of This Q");
                        Console.WriteLine("1 --> True\t0 --> False");
                        input = Console.ReadLine();
                    }
                    while (string.IsNullOrEmpty(input) || (input != "0" && input != "1")
                    || !byte.TryParse(input, out ans));

                    //Console.WriteLine(new TorFAnswer(ans == 0 ? false : true).QAnswer);
                    return new TorFAnswer(ans == 0 ? false : true);
                #endregion

                #region ChooseOne
                case QuestionType.ChooseOne:
                    string a, b, c, d;
                    ChoicesAnsEnum ansEnum;

                    do
                    {
                        Console.WriteLine("Enter Choice A");
                        input = Console.ReadLine();
                    }
                    while (string.IsNullOrEmpty(input));
                    a = input;

                    do
                    {
                        Console.WriteLine("Enter Choice B");
                        input = Console.ReadLine();
                    }
                    while (string.IsNullOrEmpty(input));
                    b = input;

                    do
                    {
                        Console.WriteLine("Enter Choice C");
                        input = Console.ReadLine();
                    }
                    while (string.IsNullOrEmpty(input));
                    c = input;

                    do
                    {
                        Console.WriteLine("Enter Choice D");
                        input = Console.ReadLine();
                    }
                    while (string.IsNullOrEmpty(input));
                    d = input;

                    do
                    {
                        Console.WriteLine("Enter The Right Answer of This Q");
                        Console.WriteLine("(A or B or C or D) OR (a or b or c or d)");
                        input = Console.ReadLine();
                    }
                    while (string.IsNullOrEmpty(input) || input.Length > 1
                    || !Enum.TryParse(input, true, out ansEnum));

                    return new ChooseOneAnswer(a, b, c, d, ansEnum);
                #endregion

                #region MultiChoices
                case QuestionType.MultiChoices:
                    string A, B, C, D;
                    uint numOfRightAns;
                    ChoicesAnsEnum multiAnsEnum;

                    do
                    {
                        Console.WriteLine("Enter Choice A");
                        input = Console.ReadLine();
                    }
                    while (string.IsNullOrEmpty(input));
                    A = input;

                    do
                    {
                        Console.WriteLine("Enter Choice B");
                        input = Console.ReadLine();
                    }
                    while (string.IsNullOrEmpty(input));
                    B = input;

                    do
                    {
                        Console.WriteLine("Enter Choice C");
                        input = Console.ReadLine();
                    }
                    while (string.IsNullOrEmpty(input));
                    C = input;

                    do
                    {
                        Console.WriteLine("Enter Choice D");
                        input = Console.ReadLine();
                    }
                    while (string.IsNullOrEmpty(input));
                    D = input;

                    return new MultiChoicesAnswers(A, B, C, D
                        , RighAnswer(out numOfRightAns, out input, out multiAnsEnum));
                #endregion

                default:
                    return null;
            }
        }

        static ChoicesAnsEnum RighAnswer(out uint numOfRightAns, out string? input, out ChoicesAnsEnum multiAnsEnum)
        {
            multiAnsEnum = default;

            do
            {
                Console.WriteLine("Enter Number of Right Answers");
                input = Console.ReadLine();
            }
            while (string.IsNullOrEmpty(input) || !uint.TryParse(input, out numOfRightAns) 
            || numOfRightAns == 0);

            bool check = true;
            ChoicesAnsEnum eachChoice;

            while (check)
            {
                do
                {
                    Console.WriteLine("Enter The Right Answers of This Q (Select Multi Choices)");
                    Console.WriteLine("Enter Multi Choices , separated");
                    Console.WriteLine("(A or B or C or D) OR (a or b or c or d)");
                    input = Console.ReadLine();
                }
                while (string.IsNullOrEmpty(input) || input.Split(',').Length != numOfRightAns);

                for(int i = 0; i < numOfRightAns; i++)
                {
                    bool b = Enum.TryParse(input.Split(',')[i], true, out eachChoice);

                    if (b)
                        multiAnsEnum |= eachChoice;
                    else
                        break;

                    if (i + 1 == numOfRightAns && b)
                        check = false;
                }
            }

            //Console.WriteLine(multiAnsEnum);

            return multiAnsEnum;
        }
        #endregion
    }
}
