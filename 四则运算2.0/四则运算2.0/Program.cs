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
            Console.WriteLine("您的孩子是几年级，请在下方输入对应编号（1.一年级,2.二年级,3.三年级,4.四年级,5.五年级）,例如：1");
            int serial = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("您想要生成多少题");
            int difficulty = Convert.ToInt32(Console.ReadLine());
            Stopwatch sp = new Stopwatch();
            sp.Start();
            foreach (string s in generate(serial, difficulty))
            {
                Console.WriteLine(s);
            }
            Generate_TXT.generate_TXT(generate(serial, difficulty));
            sp.Stop();
            Console.WriteLine(sp.Elapsed.ToString());
            Console.ReadKey();
        }

        public static string[] generate(int serial, int difficulty)
        {
            Random number = new Random(); //实例化一个随机数     
            int[] tis= ti(serial);
            string[] generates = new string[difficulty];
            for (int s = 0; s < difficulty; s++)
            {
               int nubere_shu = number.Next(1, tis[1] + 1); //随机几则运算               
               generates[s]= Operation.formula(tis[2], nubere_shu, tis[0]);//输出结果                
            }
            return generates;
        }
        public static int[] ti(int Serial)
        {
            int[] tis = new int[3];
            switch (Serial)
            {
                case 1:
                    tis[0] = 2;                    
                    tis[1] = 2;
                    tis[2] = 100;
                  
                    break;
                case 2:
                    tis[0] = 4;
                    tis[1] = 3;
                    tis[2] = 100;
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;               
            }

            return tis;
        }

       

    }
}
