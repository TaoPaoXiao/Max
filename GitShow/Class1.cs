using System;
using System.Collections.Generic;
using System.Text;

namespace GitShow
{
    class Class1
    {
        static void Main(string[] args)
        {

            int max = 1000;
            int stepLength = 10;
            bool seccess = false;
            int random = new Random().Next(max);
            Console.WriteLine($"请输入一个不超过{max}以内的自然数:");
            for (int i = 0; i < 10; i++)
            {
                int reslut = Convert.ToInt32(Console.ReadLine());
                stepLength--;
                if (reslut > random)
                {

                    Console.WriteLine($"不好意思，你输入的数太大了,还剩{stepLength}次");
                }
                else if (reslut < random)
                {
                    Console.WriteLine($"不好意思，你输入的数太小了，还剩{stepLength}次");
                }
                else if (reslut == random)
                {
                    Console.WriteLine($"恭喜你输入正确");
                    seccess = true;
                    break;
                }
            }
            if (!seccess)
            {
                Console.WriteLine("很遗憾你没有找到");
            }
            Console.Read();
        }
    }
}
