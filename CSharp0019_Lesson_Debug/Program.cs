//本程序中包含一下内容：
//1.C#中的断点：断点是源代码中⾃动进⼊中断模式的⼀个标记，当遇到断点的时候，程序会进⼊中断模式
//2.C#Debug时的一些布局：
//  局部变量：可以看到当前执行函数中的变量值
//  调用堆栈：可以看到当前行，执行的函数路径
//  即时窗口：可以修改或查看变量的值
//3.C# VS2022调试的方法：
//  继续：程序会运行到下一个断点
//  逐语句：一步一步执行，遇到函数时会进入(F11)
//  逐过程：一步一步执行，遇到函数不会进入，直接得到函数结果(F10)
//  跳出：跳出当前函数

internal class Program
{
    static int Add(int a, int b)
    {
        int result = a + b;
        return result;
    }

    private static void Main(string[] args)
    {
        int result = Add(98, 22);
        int a = 123;
        int b = 456;
        int c = 789;
        Console.WriteLine(result);
    }
}