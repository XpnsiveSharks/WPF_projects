using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_projects.DB;

namespace WPF_projects.ScrambleWords.Commons
{
    public class CollectionAttributes
    {
        public int ID { get; set; }
        public string WORD { get; set; }
        public string HINT { get; set; }
        public string DIFFICULTY { get; set; }
        public int SCORE { get; set; }
        public string Display()
        {
            return String.Format("{0}: {1}, {2}, {3}, {4}", ID, WORD, HINT, DIFFICULTY, SCORE);
        }
    }
}
