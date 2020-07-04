using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
   public class IsAnagramSolution
    {
        public bool IsAnagram(string s, string t)
        {
            IDictionary<char, int> first = GetCountByCharacter(s);
            IDictionary<char, int> second = GetCountByCharacter(t);

            return first.Count == second.Count && !first.Except(second).Any();
        }

        private IDictionary<char, int> GetCountByCharacter(string s)
        {
            IDictionary<char, int> countByCharacter = new Dictionary<char, int>();

            if (s != null)
            {
                foreach (char ch in s)
                {
                    if(countByCharacter.ContainsKey(ch))
                    {
                        countByCharacter[ch]++;
                    } else
                    {
                        countByCharacter.Add(ch, 1);
                    }
                }
            }

            return countByCharacter;
        }
    }
}
