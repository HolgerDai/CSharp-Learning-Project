//本程序中包含以下内容:
//1.C#中的递归函数：调⽤⾃⾝的函数就是递归函数。
//注意点1：递归函数要有递归终⽌的条件（不然程序执行会进入死循环）
//注意点2：递归的效率很慢，时间会花很久，因为程序在不断调用函数

//例：f(n)=f(n-1)+f(n-2) f(0)=2 f(1)=3 ,⽤程序求得f(40)
//1.可以用循环来解决
//2.可以用递归来解决

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(LoopWay(40));         //循环来解决的输出结果
        Console.WriteLine(RecursiveWay(40));    //递归来解决的输出结果
    }

    //循环来解决
    static int LoopWay(int n) 
    {

        int j = 2;
        int k = 3;
        int result = 0;
        if (n == 0)
        {
            result = j;
        }
        else if (n == 1)
        {
            result = k;
        }
        else
        {
            for (int i = 1; i < n; i++)
            {
                result = j + k;
                j = k;              //为下一轮计算做准备，下一轮第一个被加数为此轮第二个数
                k = result;         //为下一轮计算做准备，下一轮第二个被加数为此轮的结果
            }
        }
        return result;
    }

    //递归来解决
    static int RecursiveWay(int n)
    {
        int j = 2;
        int k = 3;
        int result = 0;
        if (n == 0)
        {
            result = j;
        }
        else if (n == 1)
        {
            result = k;
        }
        else
        {
            result = RecursiveWay(n - 1) + RecursiveWay(n - 2);
        }
        return result;
    }

}