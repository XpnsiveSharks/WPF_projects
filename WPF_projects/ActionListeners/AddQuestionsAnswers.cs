using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_projects.DB;

namespace WPF_projects.ActionListeners
{
    public class AddQuestionsAnswers
    {
        DBConn db = new DBConn();
        public int CARDS_ID { get; set; }
        public string QUESTIONS { get; set; }
        public string ANSWERS { get; set; }
        public int DECK_ID { get; set; }


        public void AddData(string question, string answer, int deckId)
        {
            string query = "INSERT INTO TBL_CARDS(QUESTIONS, ANSWERS, DECK_ID) VALUES ('" + question + "','" + answer + "','" + deckId + "')";
            db.Execute(query);
        }
        public List<AddQuestionsAnswers> GetAllCardsInfo()
        {
            List<AddQuestionsAnswers> list = new List<AddQuestionsAnswers>();
            string sql = "SELECT * FROM TBL_CARDS";
            SqlDataReader dr = db.Execute(sql);

            while (dr.Read())
            {
                AddQuestionsAnswers aqa = new AddQuestionsAnswers();
                aqa.CARDS_ID = (int)dr["CARDS_ID"];
                aqa.QUESTIONS = dr["QUESTIONS"].ToString();
                aqa.ANSWERS = dr["ANSWERS"].ToString();
                aqa.DECK_ID = (int)dr["DECK_ID"];
                list.Add(aqa);
            }
            dr.Close();
            db.Close();
            return list;
        }
    }
}