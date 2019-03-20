using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace 四则运算2._0
{
     public class Operation
    {
        public static DataTable dT=new DataTable ();
        public static Random number = new Random ();
        public static string[] operatos = new string[] { "＋", "－", "×", "÷" };//输出用运算符数组
        public static string[] operatos1 = new string[] { "+", "-", "*", "/" };//运算用运算符数组

        /// <summary>
        /// 用于生成公式
        /// </summary>
        /// <param name="difficulty">取值范围</param>
        /// <param name="shu">几则运算</param>
        /// <returns></returns>
        public static string formula(int difficulty, int shu)
        {
            string number1 = number.Next(0, difficulty).ToString();//运算公式自然数
            string results= number1;//用于输出
            string results1 = number1;//用于计算
            for (int s=0;s< shu; s++)
            {
                int number_op = number.Next(0, 4);//随机一次运算符
                number1 = number.Next(1, difficulty).ToString();//随机一个自然数
                results += operatos[number_op]+number1;//把运算符和自然数添加进用于计算的字符串
                results1 += operatos1[number_op]+number1;//把运算符和自然数添加进用于输出的字符串
            }
            string st = dT.Compute(results1,"null").ToString();//计算字符串类型公式的结果
            Regex reg = new Regex(@"^\d+\.\d+$");
            if (reg.IsMatch(st))
            {
               st=Score.score(double.Parse(st));
            }
            results += "=" + st.ToString();//把运算结果添加输出字符串
            if (double.Parse(dT.Compute(st, "null").ToString())< 0 || st.ToString() == "∞"|| Regex.Match(st.ToString(), @"(?<=\.)\d+").Value.Length>5)//判断结果 如果小于0或无穷大 则重新运行一次
            {
                results = formula(difficulty, shu);
            }         
           
            return results;//把最终的输出公式返回
        }       
    }
}
