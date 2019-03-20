using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 四则运算2._0
{
    class Program
    {
        static void Main(string[] args)
        {

            Random number = new Random(); //实例化一个随机数         
            Console.WriteLine("要生成多少题，最多支持10000题");
            int draw = Convert.ToInt32(Console.ReadLine()); //获取出题量
            Console.WriteLine("要生多少以内的计算题(0~100之内)");
            Stopwatch sp = new Stopwatch();
            sp.Start();
            int difficulty = Convert.ToInt32(Console.ReadLine()); //获取出题量 

            for (int s = 0; s < draw; s++)
            {

                int nubere_shu = number.Next(1, 5); //随机几则运算               
                Console.WriteLine(Operation.formula(difficulty, nubere_shu));//输出结果
                //Operation.formula(difficulty, nubere_shu);//输出结果
            }
            sp.Stop();
            Console.WriteLine(sp.ElapsedMilliseconds.ToString() + "毫秒");
            Console.WriteLine(sp.Elapsed.ToString() + "毫秒");
            Console.ReadKey();
        }
    }
}
