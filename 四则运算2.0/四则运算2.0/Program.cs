using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 四则运算2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable dt = new DataTable();
            Random number = new Random(); //实例化一个随机数           
            string[] operatos = new string[] { "＋", "－", "×", "÷" };
            string[] operatos1 = new string[] { "+", "-", "*", "/" };
            Console.WriteLine("要生成多少题，最多支持10000题");
            int draw = Convert.ToInt32(Console.ReadLine()); //获取出题量
            Console.WriteLine("要生多少以内的计算题(0~100之内)");
            int difficulty = Convert.ToInt32(Console.ReadLine()); //获取出题量                                                                 
            for (int s = 0; s < draw; s++)
            {
                int nuber_ti = number.Next(0, 3);
                int nubere_shu = number.Next(1, 4);
                switch (nuber_ti)
                {
                    case 0:
                        Console.WriteLine(Operation.formula4(dt, number, difficulty, operatos, operatos1,nubere_shu));
                        break;
                    case 1:
                        Console.WriteLine(Operation.formula4(dt, number, difficulty, operatos, operatos1, nubere_shu));
                        break;
                    case 2:
                        Console.WriteLine(Operation.formula4(dt, number, difficulty, operatos, operatos1, nubere_shu));
                        break;
                }


            }
            Console.ReadKey();
        }
    }
}
