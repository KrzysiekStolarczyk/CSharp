namespace JanuszowyExpert.Models
{
    public class Questions
    {
        public string QuestionContext { get; set; }


        public Questions(string QuestionContext1)
        {
            QuestionContext = QuestionContext1;
        }

        public Questions()
        {
                
        }


        public void AskQuestions()
        {

            QuestionContext = "Czy chcesz aby Janusz pomógł Ci wybrać samochód twoich marzeń?";

        }
    }
}
