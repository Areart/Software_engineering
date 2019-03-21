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
        public static void generate_TXT(string[] cDirs)
        {
            using (StreamWriter sw = new StreamWriter("CDriveDirs.txt"))
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
