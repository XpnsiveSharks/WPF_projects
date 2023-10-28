using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows;

namespace WPF_projects.ActionListeners
{
    public class CardsQuestions
    {
        // connection string and query
        string questionConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Prince\Desktop\C#\WPF_projects\WPF_projects\RevAppDB.mdf;Integrated Security=True;Connect Timeout=30";
        string questionQuery = "SELECT QUESTIONS FROM TBL_CARDS";

        // Create an instance of the QuestionAnswerManager which is questionManager
        QuestionAnswerManager<string> questionManager;

        public CardsQuestions()
        {
            // Initialize the manager in the constructor
            questionManager = new QuestionAnswerManager<string>(questionConnectionString, questionQuery);
        }

        public string GetNextQuestion()
        {
            // gets the next question
            string nextAnswer = questionManager.GetNextItem();
            if(string.IsNullOrEmpty(nextAnswer))
            {
                return "No more answers availables.";
            }
            return nextAnswer;
        }

       /* public void ClearCurrentQuestion()
        {
            // clears the current question
            questionManager.ClearItem();
        }*/
    }
}
