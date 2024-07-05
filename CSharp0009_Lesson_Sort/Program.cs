//本程序中包含以下内容
//C#中的排序方法：
//      1.系统自带的Array.Sort()方法
//      2.手搓冒泡排序法(暴力排序法)

internal class Program
{
    private static void Main(string[] args)
    {
        //读取用户输入，并转换成int数组
        Console.WriteLine("请输入一组数字（空格分割），系统会自动为其排序：");
        string userInput = Console.ReadLine();
        string[] strList = userInput.Split(" ");
        int[] numList = new int[strList.Length];
        int i;
        for (i = 0; i < strList.Length; i++)
        {
            numList[i] = System.Convert.ToInt32(strList[i]);
        }

        //排序方法1：系统自带Array.Sort方法
        //Array.Sort(numList);

        //排序方法2：手搓冒泡排序法
        //直接版：虽然实现了，但是不是最优的写法，未考虑每次循环时，已排序好的不用比较
        //for (int i1 = 0; i1 < numList.Length - 1; i1++)
        //{
        //    for (int i2 = 0; i2 < numList.Length - 1; i2++)
        //    {
        //        if (numList[i2] > numList[i2 + 1])
        //        {
        //            int temp = numList[i2];
        //            numList[i2] = numList[i2 + 1];
        //            numList[i2 + 1] = temp;
        //        }
        //    }
        //}

        //优化版-1：虽然优化了，已排序好的不用比较，但仍然不是最优的，因为排序到中途可能已经排序完成了
        //for (int i1 = 0; i1 < numList.Length-1; i1++) //需要循环Length-1次
        //{
        //    for (int i2 = 0; i2 < numList.Length-1-i1; i2++) //每次循环里，需要做(Length-1-当前次数)次比较
        //    {
        //        if(numList[i2] > numList[i2 + 1])
        //        {
        //            int temp = numList[i2];
        //            numList[i2] = numList[i2 + 1];
        //            numList[i2+1] = temp;
        //        }
        //    }
        //}


        //优化版-2：最优化版、既考虑了已排序的不必排序，又考虑了中途排序成功后可直接退出
        Boolean stopFlag = false;
        for (int i1 = 0; i1 < numList.Length - 1; i1++) //需要循环Length-1次
        {
            for (int i2 = 0; i2 < numList.Length - 1 - i1; i2++) //每次循环里，需要做(Length-1-当前次数)次比较
            {
                if (numList[i2] > numList[i2 + 1])
                {
                    int temp = numList[i2];
                    numList[i2] = numList[i2 + 1];
                    numList[i2 + 1] = temp;
                    stopFlag = true;
                }
            }
            if (stopFlag == true)
            {
                break;
            }
        }

        //输出结果
        foreach (int num in numList)
        {
            Console.Write(num + " ");
        }
    }
}