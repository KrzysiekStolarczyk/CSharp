using System.Collections.Generic;

namespace JanuszowyExpert.Models
{
    public class AllQuestions
    {
        public int IdQuestion { get; set; }
        public string ContextQuestion { get; set; }
        public int AnswerTrue { get; set; }
        public int AnswerFalse { get; set; }


        public AllQuestions()
        {

        }


        public AllQuestions(int IdQuestion, string ContextQuestion, int AnswerTrue, int AnswerFalse)
        {
            this.IdQuestion = IdQuestion;
            this.ContextQuestion = ContextQuestion;
            this.AnswerTrue = AnswerTrue;
            this.AnswerFalse = AnswerFalse;
        }

        public static void AddtoListQuestions(List<AllQuestions> Questi)
        {
            Questi.Add(new AllQuestions(0, "Czy chcesz aby Janusz pomógł Ci wybrać samochód twoich marzeń ? ", 1, 0));
            Questi.Add(new AllQuestions(1, "Czy chcesz samochód rodzinny(kombi,minivan,SUV) ? ", 3, 3));
            Questi.Add(new AllQuestions(2, "Czy chcesz samochód sportowy?", 1, 2));
            Questi.Add(new AllQuestions(3, "Czy chcesz samochód ekonomiczny?", 4, 4));
            Questi.Add(new AllQuestions(4, "Jakie paliwo(benzyna)?", 5, 5));
            Questi.Add(new AllQuestions(5, "Czy samochod ma być ponizej 2003 roku?", 7, 6));
            Questi.Add(new AllQuestions(6, "Czy samochod ma być z rocznika 2003-2010?", 7, 7));
            Questi.Add(new AllQuestions(7, "Czy przebieg ma być ponizej 150 tyś km?", 8, 8));
            Questi.Add(new AllQuestions(8, "Czy chcesz samochód Niemkieckiej produkcji?", 10, 9));
            Questi.Add(new AllQuestions(9, "Czy chcesz samochód Włoskiej produkcji?", 10, 10));

        }



    }
}
