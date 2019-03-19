using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 四则运算2._0
{
     public class Operation
    {
        /// <summary>
        /// 一个运算符
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="number"></param>
        /// <param name="difficulty"></param>
        /// <param name="operatos"></param>
        /// <param name="operatos1"></param>
        /// <returns></returns>
        public static string formula1(DataTable dt, Random number, int difficulty, string[] operatos, string[] operatos1)
        {
            string number1 = number.Next(0, difficulty).ToString();
            string number2 = number.Next(0, difficulty).ToString();
            int number_op = number.Next(0, 4);
            string results = dt.Compute(number1 + operatos1[number_op] + number2, "false").ToString();
            string results1 = number1 + operatos[number_op] + number2 + "=" + results;
            if (Convert.ToDouble(results) < 0|| results == "∞")
            {
                results1 = formula1(dt, number, difficulty, operatos, operatos1);
            }
            return results1;
        }

        /// <summary>
        /// 两个运算符
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="number"></param>
        /// <param name="difficulty"></param>
        /// <param name="operatos"></param>
        /// <param name="operatos1"></param>
        /// <returns></returns>
        public static string formula2(DataTable dt, Random number, int difficulty, string[] operatos, string[] operatos1)
        {
            string number1 = number.Next(0, difficulty).ToString();
            string number2 = number.Next(0, difficulty).ToString();
            string number3 = number.Next(0, difficulty).ToString();
            int number_op = number.Next(0, 4);
            int number_op1 = number.Next(0, 4);
            string results = dt.Compute(number1 + operatos1[number_op] + number2 + operatos1[number_op1] + number3, "false").ToString();
            string results1 = number1 + operatos[number_op] + number2 + operatos1[number_op1] + number3 + "=" + results;
            if (Convert.ToDouble(results) < 0 || results == "∞")
            {
                results1 = formula2(dt, number, difficulty, operatos, operatos1);
            }
            return results1;
        }
        /// <summary>
        /// 三个运算符
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="number"></param>
        /// <param name="difficulty"></param>
        /// <param name="operatos"></param>
        /// <param name="operatos1"></param>
        /// <returns></returns>
        public static string formula3(DataTable dt, Random number, int difficulty, string[] operatos, string[] operatos1)
        {
            string number1 = number.Next(0, difficulty).ToString();
            string number2 = number.Next(0, difficulty).ToString();
            string number3 = number.Next(0, difficulty).ToString();
            string number4 = number.Next(0, difficulty).ToString();
            int number_op = number.Next(0, 4);
            int number_op1 = number.Next(0, 4);
            int number_op2 = number.Next(0, 4);
            string results = dt.Compute(number1 + operatos1[number_op] + number2 + operatos1[number_op1] + number3 + operatos1[number_op2] + number4, "false").ToString();
            string results1 = number1 + operatos[number_op] + number2 + operatos[number_op1] + number3 + operatos[number_op2] + number4 + "=" + results;
            if (Convert.ToDouble(results) < 0 || results == "∞")
            {
                results1 = formula3(dt, number, difficulty, operatos, operatos1);
            }
            return results1;
        }
    }
}
