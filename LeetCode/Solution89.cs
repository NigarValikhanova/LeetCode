using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Solution89
    {
        public IList<int> GrayCode(int n)
        {
            List<int> grayCode = new List<int>();
            int numElements = 1 << n; // 2^n elements

            for (int i = 0; i < numElements; i++)
            {
                grayCode.Add(i ^ (i >> 1));
            }

            return grayCode;
        }
    }
}
