using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_projects.ActionListeners
{
    public class CardsAnswers
    {
        // connection string and query
        string questionConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Prince\Desktop\C#\WPF_projects\WPF_projects\RevAppDB.mdf;Integrated Security=True;Connect Timeout=30";
        string answersQuery = "SELECT ANSWERS FROM TBL_CARDS";
        QuestionAnswerManager<string> answerManager;
        public CardsAnswers()
        {
            // Initialize the manager in the constructor
            answerManager = new QuestionAnswerManager<string>(questionConnectionString, answersQuery);
        }
        public string GetNextAnswer()
        {
            // gets the next question
            return answerManager.GetNextItem();
        }

    }
}
