namespace ExamComponents
{
    public enum QuestionType : byte
    {
        TrueOrFalse = 1, ChooseOne, MultiChoices
    }

    [Flags]
    public enum ChoicesAnsEnum : byte
    {
        A = 1, B = 2, C = 4, D = 8,
        a = 1, b = 2, c = 4, d = 8
    }
}
