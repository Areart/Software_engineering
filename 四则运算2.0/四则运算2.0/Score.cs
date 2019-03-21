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
        /// <summary>
        /// 小数转分数
        /// </summary>
        /// <param name="d">小数</param>
        /// <returns></returns>
        public static string score(double d)
        {
            string dn = Regex.Match(d.ToString(), @"(?<=\.)\d+").Value;//去小数点
            int denominator = 1;
            for (int i = dn.Length; i > 0; i--)
            {
                denominator *= 10;
            }
            double[] sr = score_reduction(d * denominator, denominator);
            return sr[0].ToString() + "/" + sr[1].ToString();
        }

        /// <summary>
        /// 分数化简
        /// </summary>
        /// <param name="a">分子</param>
        /// <param name="b">分母</param>
        /// <returns></returns>
        public static double[] score_reduction(double a, double b)
        {
            double max_nub = 0;
            if (a % b == 0 || b % a == 0)
            {
                max_nub = a > b ? b : a;
            }         
            max_nub = max(a, b);//求最大公约数          
            b = b / max_nub;
            a = a / max_nub;
            double[] score = new double[] { a, b };
            return score;
        }

        /// <summary>
        /// 求公约数
        /// </summary>
        /// <param name="a">分子</param>
        /// <param name="b">分母</param>
        /// <returns></returns>
        public static double max(double a, double b)
        {
            while (b != 0)
            {
                double maxNum = a % b;
                a = b;
                b = maxNum;
            }
            return a;
        }
    }
}
