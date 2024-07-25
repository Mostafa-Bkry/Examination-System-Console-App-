using System;

namespace Exam
{
    public class Subject
    {
        string subName;
        string profName;
        string deptName;
        uint fullMark;

        public Subject(string subname, string profname, string deptname, uint fullmark)
        {
            subName = subname;
            profName = profname;
            deptName = deptname;
            fullMark = fullmark;
        }

        public string SubName { get => subName; }
        public string ProfName { get => profName; }
        public string DeptName { get => deptName; }
        public uint FullMark { get => fullMark; }

        public override string ToString()
        {
            return $"Subject: {subName}\tProfessor: {profName}\nDepartment: {deptName}\t\tMarks: {fullMark}";
        }
    }
}
