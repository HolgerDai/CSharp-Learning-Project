//本程序中包含以下内容
//1.C#中注释的方法-行注释、块注释、注释的组合快捷键
//2.C#中调试的方法-快捷键F5
//3.C#中控制台输出以及两个方法-WriteLine与Write的区别
//4.C#中控制台输出时的转义字符
//  \n 换行符 \t 制表符（制表符输出的空格在不同软件显示长度不同）
//  反斜杠本身可代表转义，比如想要输出反斜杠本身或者双引号需要使用\
//  转义在Lesson3中会提到，还可以使用@进行整个字符串的转义
//5.C#编译过程
//  代码->VS2022先编译为程序集,有两种：exe文件可直接执行；dll文件不可执行，只供引用其中代码
//  当程序集运行时，计算机系统将程序集编译为机器指令
//  注意：由于C#是先编译为程序集，程序集是必须在.Net框架下运行的；而一些其他语言直接编译为机器代码的，系统可直接执行
//6.C#中快捷复制行的快捷键 光标放至某行后 Ctrl+D

//类
internal class Program
{
    //Main方法
    private static void Main(string[] args)
    {
        //注释的2个方法
        //1.两个斜杠是行注释
        /*2.斜杠加星号是块注释*/

        //快捷注释单行方法:光标移到需要注释的行，可使用组合快捷键
        //注释：Ctrl+K再按Ctrl+C 反注释：Ctrl+K再按Ctrl+U
        Console.WriteLine("测试单行快捷注释");

        //快捷注释多行方法：选中需要注释的内容，可使用组合快捷键（和单行注释一样）
        Console.WriteLine("测试多行快捷注释");
        Console.WriteLine("测试多行快捷注释");
        Console.WriteLine("测试多行快捷注释");

        //通过控制台输出，Console为System命名空间下的一个对象
        //.Net 8.0已不需要Using System，在配置文件中已设定隐藏
        Console.WriteLine("Hello, World! Test");

        //控制台输出的两个方法-WriteLine与Write的区别
        //WriteLine，输出完后会自动换行
        //Write，输出完后不会换行
        Console.WriteLine("测试WriteLine1");
        Console.WriteLine("测试WriteLine2");
        Console.WriteLine("测试WriteLine3");
        Console.Write("测试Write1");
        Console.Write("测试Write2");
        Console.Write("测试Write3");

        //转义字符，\n 换行符 \t 制表符（制表符输出的空格在不同软件显示长度不同）
        Console.WriteLine("Hello \n World");
        Console.WriteLine("Hello \t World");

        //反斜杠本身可代表转义，比如想要输出反斜杠本身或者双引号需要使用\
        Console.WriteLine("Hello \\");
        Console.WriteLine("Hello \"");

        //测试Ctrl+D快捷复制行
        Console.WriteLine("Hello World");
        Console.WriteLine("Hello World");
        Console.WriteLine("Hello World");

    }
}