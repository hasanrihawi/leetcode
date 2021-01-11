using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode
{
    public class ZigzagConversionSolution
    {
        public string Convert(string s, int numRows)
        {
            List<StringBuilder> rows = new List<StringBuilder>();

            int currRow = 0;
            bool goingDown = false;

            for (int i = 0; i < s.Length; i++)
            {
                if (currRow >= rows.Count)
                    rows.Add(new StringBuilder());

                rows[currRow].Append(s[i]);
                if (currRow == 0 || currRow == numRows - 1)
                    goingDown = !goingDown;

                currRow += goingDown ? +1 : -1;
            }

            StringBuilder res = new StringBuilder();
            foreach (var row in rows)
                res.Append(row);
            return res.ToString();
        }
    }

}
