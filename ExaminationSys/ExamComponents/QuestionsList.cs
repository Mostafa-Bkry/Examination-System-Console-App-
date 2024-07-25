using System;

namespace ExamComponents
{
    public class QuestionsList
    {
        static int newObject;
        string path;
        List<Question> list;

        public QuestionsList()
        {
            newObject++;
            //Relative Path
            path = @$".\Questions{newObject}.txt";
            list = new List<Question>();
        }

        #region Props
        public string Path { get => path; }

        public static int NewObject { get => newObject; }

        public List<Question> List { get => list; }

        //Add Any type of questions To the list
        public Question Add
        {
            set
            {
                list.Add(value);

                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.WriteLine(value);
                }
            }
        }
        #endregion

        #region Indexers
        //return List of same question type
        public List<Question> this[Question questionType]
        {
            get
            {
                List<Question> result = new List<Question>();
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].GetType() == questionType.GetType())
                        result.Add(list[i]);
                }

                return result;
            }
        }
        #endregion
    }
}
