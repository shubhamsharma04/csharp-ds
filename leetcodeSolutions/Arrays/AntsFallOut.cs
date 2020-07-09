using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class AntsFallOut
    {
        public int GetLastMoment(int n, int[] left, int[] right)
        {
            var nextLeft = new HashSet<int>();
            foreach (int element in left) {
                if(element > 0)
                {
                    nextLeft.Add(element - 1);
                }
            }
            var nextRight = new HashSet<int>();
            foreach (int element in right)
            {
                if (element < n)
                {
                    nextLeft.Add(element + 1);
                }
            }

            return GetLastMoment(n, nextLeft, nextRight, 1) - 1;
        }

        private int GetLastMoment(int n, HashSet<int> left, HashSet<int> right, int time)
        {
            if(left.Count == 0 && right.Count == 0)
            {
                return time;
            }

            var nextLeft = new HashSet<int>();
            var nextRight = new HashSet<int>();

            foreach (int element in left)
            {
                if (right.Contains(element))
                {
                    nextRight.Add(element + 1);
                }
                else
                {
                    if (element > 0)
                    {
                        nextLeft.Add(element - 1);
                    }
                }
            }

            foreach (int element in right)
            {
                if (left.Contains(element))
                {
                    nextLeft.Add(element - 1);
                }
                else
                {
                    if (element < n)
                    {
                        nextRight.Add(element + 1);
                    }
                }
            }

            return GetLastMoment(n, nextLeft, nextRight, time + 1);
        }
    }
}
