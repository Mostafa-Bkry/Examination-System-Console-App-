using System;

namespace ExamTypes
{
    public class Subject
    {
        string subName;
        string profName;
        string deptName;
        uint fullMark;
        List<Subject> subjects;

        public Subject(string subname, string profname, string deptname, uint fullmark)
        {
            subName = subname;
            profName = profname;
            deptName = deptname;
            fullMark = fullmark;
            //subjects = new List<Subject>();
            //subjects.Add(this);
            subjects = [this];
        }

        public string SubName { get => subName; }
        public string ProfName { get => profName; }
        public string DeptName { get => deptName; }
        public uint FullMark { get => fullMark; }
        public List<Subject> Subjects { get => subjects; }

        public override string ToString()
        {
            return $"Subject: {subName}\tProfessor: {profName}\nDepartment: {deptName}\t\tMarks: {fullMark}";
        }
    }
}
