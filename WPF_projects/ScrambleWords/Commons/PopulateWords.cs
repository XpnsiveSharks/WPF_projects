using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_projects.ScrambleWords.Commons
{
    public class PopulateWords<TKey, TValue>
    {
        private TKey _key;
        private TValue _value;
        public PopulateWords(TKey key, TValue value)
        {
            _key = key;
            _value = value;
        }
        public string Print()
        {
            string k = _key.ToString();
            string v = _value.ToString();
            return $"the key is {k}, and the value is {v}";
        }
       
    }
}
