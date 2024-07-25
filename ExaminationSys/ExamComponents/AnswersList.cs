using System;

namespace ExamComponents
{
    public class AnswersList
    {
        List<Answer> list;

        public AnswersList()
        {
            list = new List<Answer>();
        }

        //#region Props
        //public Answer Add
        //{
        //    set
        //    {
        //        list.Add(value);
        //    }
        //}
        //#endregion

        #region Indexers
        public Answer this[Question q]
        {
            set
            {
                list.Add(value);
            }
        }

        //return List of same answer type
        public List<Answer> this[Answer answer]
        {
            get
            {
                List<Answer> result = new List<Answer>();

                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].GetType() == answer.GetType())
                        result.Add(list[i]);
                }

                return result;
            }
        }
        #endregion
    }
}
