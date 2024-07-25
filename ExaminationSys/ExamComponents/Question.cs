namespace ExamComponents
{
    public abstract class Question
    {
        string header, body;
        uint mark;

        public string Header { get => header; protected set => header = value; }
        public string Body { get => body; protected set => body = value; }
        public uint Mark { get => mark; protected set => mark = value; }

        public Question(string _header, string _body, uint _mark)
        {
            header = _header;
            body = _body;
            Mark = _mark;
        }

        public override string ToString()
        {
            return $"Q: {header}\t({mark})\n--> {body}";
        }
    }
}
