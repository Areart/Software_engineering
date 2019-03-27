using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace ConsoleApp2
{
    class CM21
    {
        public class Grade
        {
            public string Grades { get; set; } //年级
          
            public int Exercises { get; set; } //题目数量

            public string Range { get; set; }  //取值范围
            public int Operator { get; set; }//运算符数量
            public string[] OperatorClass { get; set; }  //运算符总类
            public string GetName()
            {
                return Grades+Exercises.ToString()+Range+Operator.ToString();
            }
        }

        public class JsonPaserWeb
        {
            // Object->Json
            public string Serialize(Grade obj)
            {
                JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
                string json = jsonSerializer.Serialize(obj);
                return json;
            }

            // Json->Object
            public Grade Deserialize(string json)
            {
                JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
                //执行反序列化
                Grade obj = jsonSerializer.Deserialize<Grade>(json);
                return obj;
            }
        }
    }
}
