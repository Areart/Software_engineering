using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 四则运算2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Demands = Demand().ToArray();
            Stopwatch sp = new Stopwatch();
            sp.Start();
            foreach (string s in generate(Demands))
            {
                Console.WriteLine(s);
            }
          
            sp.Stop();
            Console.WriteLine(sp.Elapsed.ToString());
            Console.ReadKey();
        }

        public static string[] generate(int[] Demands)
        {
            List<string> topic = new List<string>();
            string[] generates = new string[Demands[3]];
            for (int s = 0; s < Demands[3]; s++)
            {           
               string[] nuber_gt = Operation.formula(Demands[2], Demands[1], Demands[0]).ToArray();
               generates[s]= (s + 1 + "、") + nuber_gt[0];//输出结果      
               topic.Add((s + 1 + "、") + nuber_gt[1]);
            }
            Generate_TXT.generate_topic(topic.ToArray());
            Generate_TXT.generate_answer(generates);
            return generates;
        }
       
        public static int[] Demand()
        {
            int[] Demands = new int[4];
            Console.WriteLine("您希望生成含有乘除的计算题吗，例如：输入1，则生成只有加减的题目，输入2，则生成含有加减乘除的题目");
            Demands[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("您希望出现多少个运算符，例如：输入1，则生成只有一个运算符的");
            Demands[1] = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("您希望生成多少以内的计算题，例如：输入100，则生成100以内的数学计算题");
            Demands[2] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("您希望生成多少题，例如：输入100，则生成100道的数学题，最多10000");
            Demands[3] = Convert.ToInt32(Console.ReadLine());
            return Demands;
        }

       

    }
}
