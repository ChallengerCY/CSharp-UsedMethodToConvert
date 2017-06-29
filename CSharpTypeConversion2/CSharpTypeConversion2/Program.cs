using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTypeConversion2
{
    class Program
    {
        static void Main(string[] args)
        {
            //C#中值类型和引用类型的转换
            //值类型转换为引用类型
            int i = 5;
            string itostring = i.ToString();
            Console.WriteLine(itostring);
            //引用类型转换为值类型
            //如果输入的字符串不是数字，则会报错
            int StoI = Convert.ToInt32("100");
            int StoI2 = Int32.Parse("101");
            //如果不想处理异常，可以使用tryParse去尝试转换,如果无法转换，会个整形赋值0
            int Stol3;
            bool succeed = Int32.TryParse("10k", out Stol3);
            Console.WriteLine(Stol3);
            Console.ReadLine();
        }
    }
}
