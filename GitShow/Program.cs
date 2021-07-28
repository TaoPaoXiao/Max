using System;

namespace GitShow
{
    class Program
    {
        static void Main(string[] args)
        {//让电脑计算并输出：99+97+95+93+...+1的值
            int sum = 1;
            for (int i = 1; i <50; i++)
            {               
                sum += i * 2 + 1;
                Console.WriteLine($"第{i}次前{i+1}项和为{sum-(i*2+1)}+{i*2+1}={sum}");
            }
            Console.Read();
        }
    }
}
