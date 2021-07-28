using System;

namespace GitShow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("创建一个名为ids的数组");
            Console.WriteLine("ids；{ 1,5,9,8,7,4,1,6}");
            Console.WriteLine("依次输出数组元素");
            int[] ids = { 1,5,9,8,7,4,1,6};
            int i = 0;
            while (i<ids.Length)
            {               
                Console.WriteLine(ids[i]);
                i++;
            }
            Console.Read();
        }
    }
}
