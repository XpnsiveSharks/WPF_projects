using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_projects.ActionListeners
{
    public class QuestionAnswerManager<T>
    {
        private List<T> items;  
        private int currentIndex = -1;

        public QuestionAnswerManager(string connectionString, string query)
        {
            items = new List<T>();
            LoadItemsFromDatabase(connectionString, query);
        }
        private void LoadItemsFromDatabase(string connectionString, string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            T item = (T)Convert.ChangeType(reader[0], typeof(T));
                            items.Add(item);
                        }
                    }
                }
            }
        }

        public T GetNextItem()
        {
            if (currentIndex < items.Count - 1)
            {
                currentIndex++;
                return items[currentIndex];
            }
            else
            {
                return default(T);
            }
        }
    }
}
