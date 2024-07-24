using System;

namespace ExamComponents
{
    public class ChooseOneAnswer : Answer
    {
        protected static string[] choices;
        protected ChoicesAnsEnum rightAns;

        static ChooseOneAnswer()
        {
            choices = new string[4];
        }

        public ChooseOneAnswer(string a, string b, string c, string d, ChoicesAnsEnum right)
        {
            choices[0] = a;
            choices[1] = b;
            choices[2] = c;
            choices[3] = d;
            rightAns = right;
        }

        public static string[] Choices { get => choices; }
        public ChoicesAnsEnum RightAns { get => rightAns; }

        public override string ToString()
        {
            return $"A) {choices[0]}  B) {choices[1]}  C) {choices[2]}  D) {choices[3]}";
        }
    }
}
