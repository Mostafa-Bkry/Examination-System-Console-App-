using System;

namespace ExamComponents
{
    public class MultiChoicesAnswers : ChooseOneAnswer
    {
        public MultiChoicesAnswers(string a, string b, string c, string d, ChoicesAnsEnum right)
            : base(a, b, c, d, right)
        { }

    }
}
