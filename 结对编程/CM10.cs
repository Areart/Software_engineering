using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class CM10
    {
        public static double toDig(string str)
        {
            double n = 0, mag = 0.1;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '.') break;
                mag *= 10;
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '.') continue;
                n += mag * (str[i] - '0');
                mag /= 10;
            }
            return n;
        }
        public static double getAns(double a, double b, char c)
        {
            double s = 0;
            switch (c)
            {
                case '+': s = b + a; break;
                case '-': s = b - a; break;
                case '*': s = b * a; break;
                case '/': s = b / a; break;
            }
            return s;
        }
        public static int[] op = new int[55];
        public static double shunting(string str)
        {
            Stack<double> iStk = new Stack<double>();
            Stack<char> strStk = new Stack<char>();
            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] >= '0' && str[i] <= '9') || (i == 0 && str[i] == '-') || (str[i] == '-' && str[i - 1] == '('))
                {
                    // 判断是否为数字或负号
                    string s1 = "";
                    int f = 1;
                    int t = i;
                    if (str[i] == '-')
                    {
                        f = -1;
                        i++;
                    }
                    while ((str[i] >= '0' && str[i] <= '9') || str[i] == '.')
                    {

                        if (t < str.Length)
                        {

                            if (str[t] == '+' || str[t] == '-' || str[t] == '*' || str[t] == '/' || t >= str.Length || str[t] == ')')
                            { i = t - 1; break; }
                            s1 += str[t];
                            t++;
                            if (t >= str.Length) { i = t - 1; break; }
                        }
                        else
                            break;

                    }
                    iStk.Push(f * toDig(s1));

                }
                else
                {    //不是数字或负号，则为操作符或括号
                     // 如果栈为空、或操作符为'('、或栈顶为'('、或当前操作符的优先级大于栈顶操作符，则操作符入栈
                    if (strStk.Count == 0 || str[i] == '(' || strStk.Peek() == '(' || (str[i] != ')' && op[str[i]] > op[strStk.Peek()]))
                    {
                        if (str[i] == ')' && strStk.Peek() == '(')
                            strStk.Pop();  //当前符号和栈顶是一对括号则消除它们
                        else
                            strStk.Push(str[i]);
                    }
                    else if (str[i] == ')')
                    {
                        // 如果当前是')',则做运算直到栈顶是'('
                        char c = strStk.Peek();
                        while (c != '(')
                        {
                            double a = iStk.Pop();
                            double b = iStk.Pop();
                            strStk.Pop();
                            iStk.Push(getAns(a, b, c));
                            c = strStk.Peek();
                        }
                        strStk.Pop();
                    }
                    else
                    {
                        // 否则，说明当前运算符优先级等于或小于栈顶运算符，将栈顶操作符取出做一次运算，将运算结果压栈，最后再将当前操作符入栈
                        double a = iStk.Pop();
                        double b = iStk.Pop();
                        char c = strStk.Pop();
                        iStk.Push(getAns(a, b, c));
                        strStk.Push(str[i]);
                    }
                }
            }
            // 表达式处理完后，不断运算直到操作符空栈，此时数据栈剩下的一个数据就是最终结果
            while (strStk.Count != 0)
            {
                double a = iStk.Pop();
                double b = iStk.Pop();
                char c = strStk.Pop();
                iStk.Push(getAns(a, b, c));
            }
            return iStk.Peek();
        }
    }
}
