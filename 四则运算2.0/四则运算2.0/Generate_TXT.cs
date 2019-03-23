using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 四则运算2._0
{
    public class Generate_TXT
    {      
        public static void generate_answer(string[] cDirs)
        {
            using (StreamWriter sw = new StreamWriter("Exercise.txt"))
            {
                sw.Flush();
                foreach (string dir in cDirs)
                {
                    sw.WriteLine(dir);
                }
                sw.Close();
            }
        }
        public static void generate_topic(string[] cDirs)
        {
            using (StreamWriter sw = new StreamWriter("Answer.txt"))
            {
                sw.Flush();
                foreach (string dir in cDirs)
                {
                    sw.WriteLine(dir);
                }
                sw.Close();
            }
        }
    }
}
