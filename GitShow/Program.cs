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
            int[] ids = { 1, 5, 9, 8, 7, 4, 1, 6 };
            for (int i = 0; i < ids.Length; i++)
            {
                Console.WriteLine(ids[i]);
            }
            Console.WriteLine("创建一个名为odds的数组");
            Console.WriteLine("odds:{87,54,61,34,95,64,27}");
            Console.WriteLine("输出数组中一百以内能被3整除的数");
            Console.WriteLine("并按照从小到大来排列");
            int[] odds = { 87, 54, 61, 34, 95, 64, 27 };
            Console.Read();
        }
    }
    class BubbleSort
    {//冒泡排序
        static void BubbleSortMain(int[] intArray)
        {
            int temp = 0;
            bool swapped;
            for (int i = 0; i < intArray.Length; i++)
            {
                swapped = false;
                for (int j = 0; j < intArray.Length - 1 - i; j++)
                    if (intArray[j] > intArray[j + 1])
                    {
                        temp = intArray[j];
                        intArray[j] = intArray[j + 1];
                        intArray[j + 1] = temp;
                        if (!swapped)
                            swapped = true;
                    }
                if (!swapped)
                    return;
            }
            Console.WriteLine();
            Console.Read();
        }
    }
}
