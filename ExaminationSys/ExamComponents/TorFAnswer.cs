using System;

namespace ExamComponents
{
    public class TorFAnswer : Answer
    {
        bool qAnswer;

        public TorFAnswer(bool qAns)
        {
            qAnswer = qAns;
        }

        public bool QAnswer { get => qAnswer; }

        public override string ToString()
        {
            return "\tTrue / False";
        }
    }
}
