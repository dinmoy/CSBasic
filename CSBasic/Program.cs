using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //C#에서도 헬로 월드를?
            Console.WriteLine("Hello World!");

            //오버플로우 연습
            int a = 2000000000; //20억
            int b = 1000000000; //10억
            Console.WriteLine(a + b);

            //오버플로우 연습2
            // 작은 타입이 큰 타입으로 암묵적 변환이 됨
            //b는 int형이지만 앞에 a의 형에 맞춰 long형이됨
            Console.WriteLine((long)a + b);
            Console.WriteLine(a+(long)b);
            Console.WriteLine((long)a+(long)b);
        }
    }
}
