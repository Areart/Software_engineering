using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace 四则运算2._0
{
    public class Operation
    {
        public static DataTable dT = new DataTable();
        public static Random number = new Random();
        public static string[] operatos = new string[] { "＋", "－", "×", "÷" };              //输出用运算符数组
        public static string[] operatos1 = new string[] { "+", "-", "*", "/" };                 //运算用运算符数组




        public static List<string> formula(int difficulty, int operatos_nub, int operatos_s)
        {
            string number1 = number.Next(0, difficulty).ToString();              //运算公式自然数
            string results = number1, results1 = number1, st = null;             //用于输出           
            for (int s = 0; s < operatos_nub; s++)
            {
                int number_op = number.Next(0, operatos_s * 2);                    //随机一次运算符
                number1 = number.Next(1, difficulty).ToString();                 //随机一个自然数
                results += operatos[number_op] + number1;                        //把运算符和自然数添加进用于计算的字符串
                results1 += operatos1[number_op] + number1;                      //把运算符和自然数添加进用于输出的字符串
            }
            st = dT.Compute(results1, "null").ToString();                        //计算字符串类型公式的结果
            results += "=";
            List<string> list = NewMethod(difficulty, operatos_nub, operatos_s, ref results, ref st);
            return list;                                                         //把最终的输出公式返回
        }

        private static List<string> NewMethod(int difficulty, int number_fl, int operatos_s, ref string results, ref string st)
        {
            //Regex reg = new Regex(@"^\d+\.\d+$");
            //if (reg.IsMatch(st))
            //{
            //    st = Score.score(double.Parse(st));
            //}
            if (double.Parse(dT.Compute(st, "null").ToString()) < 0 || st.ToString() == "∞" || st.Length > 10)           //判断结果 如果小于0或无穷大 则重新运行一次2          
            {
                string[] formula_gt = formula(difficulty, number_fl, operatos_s).ToArray();
                results = formula_gt[0];
                st = formula_gt[1];
            }
            List<string> list = new List<string>();
            list.Add(results);
            list.Add(st);
            return list;
        }







        private static void CM21(string grade, int exercises, int scope)
        {
            if (exercises > 10000)
            {

            }
          
        }
        private static void CM21(string grade, int exercises, int scope,int quzhifanwei,int )
        {
            if (exercises > 10000)
            {

            }

        }

        [Serializable]//证明要进行序列化

        public class Person

        {

            public string name;

            public int age;

        }

        [Serializable]//证明要进行序列化

        public class Persons

        {

            public Person[] persons;

        }

        public class Data
        {
            public int Id { get; set; }
            // [ScriptIgnore]
            public string Name { get; set; }

            public string GetName()
            {
                return Id.ToString() + Name;
            }
        }

        public class JsonPaserWeb
        {
            // Object->Json
            public string Serialize(Data obj)
            {
                JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
                string json = jsonSerializer.Serialize(obj);
                return json;
            }

            // Json->Object
            public Data Deserialize(string json)
            {
                JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
                //执行反序列化
                Data obj = jsonSerializer.Deserialize<Data>(json);
                return obj;
            }
        }
    }
}
