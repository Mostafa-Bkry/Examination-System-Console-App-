using Exam;
using ExamComponents;

namespace ExamSys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Checking Questions Logic
            //TrueOrFalse t1 = new TrueOrFalse("TrueOrFalse 1", 1);
            //TrueOrFalse t2 = new TrueOrFalse("TrueOrFalse 2", 1);
            //TrueOrFalse t3 = new TrueOrFalse("TrueOrFalse 3", 1);
            //TrueOrFalse t4 = new TrueOrFalse("TrueOrFalse 4", 1);

            //ChooseOne c1 = new ChooseOne("ChooseOne 1", 1);
            //ChooseOne c2 = new ChooseOne("ChooseOne 2", 1);
            //ChooseOne c3 = new ChooseOne("ChooseOne 3", 1);
            //ChooseOne c4 = new ChooseOne("ChooseOne 4", 1);

            //QuestionsList questionsList = new QuestionsList();

            //questionsList.Add = t1;
            //questionsList.Add = t2;
            //questionsList.Add = t3;
            //questionsList.Add = t4;
            //questionsList.Add = c1;
            //questionsList.Add = c2;
            //questionsList.Add = c3;
            //questionsList.Add = c4;

            //foreach (var q in questionsList[t1])
            //    Console.WriteLine(q);
            #endregion

            #region Checking Answers Logic
            //TrueOrFalse t1 = new TrueOrFalse("TrueOrFalse 1", 1);
            //TrueOrFalse t2 = new TrueOrFalse("TrueOrFalse 2", 1);

            //ChooseOne c1 = new ChooseOne("ChooseOne 1", 1);
            //ChooseOne c2 = new ChooseOne("ChooseOne 2", 1);

            //MultiChoices m1 = new MultiChoices("ChooseOne 1", 1);
            //MultiChoices m2 = new MultiChoices("ChooseOne 2", 1);

            //TorFAnswer torF1 = new TorFAnswer(true);
            //TorFAnswer torF2 = new TorFAnswer(false);

            //ChooseOneAnswer ch1 = new ChooseOneAnswer("afa", "fafa", "hafa", "yafa", ChoicesAnsEnum.A);
            //ChooseOneAnswer ch2 = new ChooseOneAnswer("afa", "fafa", "hafa", "yafa", ChoicesAnsEnum.b);

            //MultiChoicesAnswers multi1 = new MultiChoicesAnswers("afa", "fafa", "hafa", "yafa"
            //    , ChoicesAnsEnum.A ^ ChoicesAnsEnum.B);
            //MultiChoicesAnswers multi2 = new MultiChoicesAnswers("afa", "fafa", "hafa", "yafa"
            //    , ChoicesAnsEnum.b ^ ChoicesAnsEnum.c);

            //QuestionsList questionsList = new QuestionsList();

            //questionsList.Add = t1;
            //questionsList.Add = t2;
            //questionsList.Add = c1;
            //questionsList.Add = c2;
            //questionsList.Add = m1;
            //questionsList.Add = m2;

            //AnswersList answersList = new AnswersList();

            //answersList[t1] = torF1;
            //answersList[t2] = torF2;
            //answersList[c1] = ch1;
            //answersList[c2] = ch2;
            //answersList[m1] = multi1;
            //answersList[m2] = multi2;

            ////foreach (var q in answersList[ch1])
            ////    Console.WriteLine(q);

            //foreach (var item in answersList.AnswerDictionary)
            //{
            //    Console.WriteLine(item.Key);

            //    Console.WriteLine(item.Value);
            //}
            #endregion

            Console.WriteLine("Enter Num of q");
            FinalExam final = new FinalExam(4);
            final.CreateExam();
        }
    }
}
