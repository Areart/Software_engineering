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


        public static string formula4(DataTable dt, Random number, int difficulty, string[] operatos, string[] operatos1,int shu)
        {
            string number1 = number.Next(0, difficulty).ToString();
            string results= number1;
            string results1 = number1;
            for (int s=0;s< shu; s++)
            {
                int number_op = number.Next(0, 4);
                number1 = number.Next(0, difficulty).ToString();
                results += operatos[number_op]+number1;
                results1 += operatos1[number_op]+number1;
            }
            double st = double.Parse(dt.Compute(results1,"null").ToString());
            results += "=" + st.ToString();
            if (st < 0 || st.ToString() == "∞")
            {
                results = formula4(dt, number, difficulty, operatos, operatos1, shu);
            }
           
           
            return results;
        }
    }
}
