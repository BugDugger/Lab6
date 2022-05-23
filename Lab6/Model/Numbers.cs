using Lab6.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab6.Model
{
    class Numbers
    {
        List<int> temp = new List<int>();
        public int returnResult(int value)
        {
            int res = 0;
            for(int i = 0; i <= value; ++i)
            {
                temp.Add(i);
            }

            for(int i = 0; i <= value; ++i)
            {
                res += temp[i];
            }

            return res;
        }

    }
}
