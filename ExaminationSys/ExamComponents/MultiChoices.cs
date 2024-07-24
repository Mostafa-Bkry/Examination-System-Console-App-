using System;

namespace ExamComponents
{
    public class MultiChoices : Question
    {
        public MultiChoices(string _body, int _mark) 
            : base("Choose All Correct Answers", _body, _mark)
        { }
    }
}
