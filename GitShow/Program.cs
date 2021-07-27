using System;

namespace GitShow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("如何获取最大值");
            int[] array = new int[] { 1, 4, 7, 2, 5, 8, 3, 6, 9, };
            Console.WriteLine("创建一个array数组为{ 1, 4, 7, 2, 5, 8, 3, 6, 9, }");
            int max = 0;
            Console.WriteLine("声明一个max使它的值为0");
            for (int i = 0; i < array.Length; i++)
            {
                if (max > array[i])
                {
                    Console.WriteLine($"如果{max}>{array[i]},那么此时最大值为{max}");

                }
                else
                {

                    Console.WriteLine($"如果{max}<{array[i]},那么此时最大值为{array[i]}");
                    max = array[i];
                }
            }

            //分别用for循环和while循环直接输出：1，2，3，4，5和1，3，5，7，9
            //用for循环输出12345
            //for (int i = 1; i < 6; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //用while循环输出12345
            //int j = 0;
            //while (true)
            //{ 
            //    if (j<5)
            //    {
            //        j++;
            //        Console.WriteLine(j);
            //        continue;
            //    }
            //    break;
            //}
            //用for循环输出13579
            //for (int i = 0; i<5; i++)
            //{
            //    Console.WriteLine(i*2+1);
            //}
            ////用while循环输出13579
            //int j = 0;
            //while (true)
            //{
            //    if (j<5)
            //    {
            //        Console.WriteLine(j*2+1);
            //        j++;
            //        continue;
            //    }
            //    break;
            //}

            //分别利用while和for循环，计算出1000+999+998+997+...+100的值
            int sum = 0;
            for (int i = 1000; i > 99; i--)
            {
                sum += i;
            }
            Console.WriteLine(sum);


            Console.Read();
        }
    }
}
