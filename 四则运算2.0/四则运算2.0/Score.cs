using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace 四则运算2._0
{
    public class Score
    {
        public static string score(double d)
        {
            string dn = Regex.Match(d.ToString(), @"(?<=\.)\d+").Value;
            int tn = 1;
            for (int i = dn.Length; i > 0; i--)
            {
                tn *= 10;
            }

            return score_reduction(d * tn, tn)[0].ToString() + "/" + score_reduction(d * tn, tn)[1].ToString();
        }

        public static double[] score_reduction(double a, double b)
        {
            double max_nub = 0;
            if (a % b == 0 || b % a == 0)
            {
                max_nub = a > b ? b : a;
            }
            else
            {
                max_nub = max(a, b);
            }
            b = b / max_nub;
            a = a / max_nub;
            double[] score = new double[] { a, b };
            return score;
        }
        public static double max(double d, double n)
        {
            while (n != 0)
            {
                double maxNum = d % n;
                d = n;
                n = maxNum;
            }
            return d;
        }
    }
}
