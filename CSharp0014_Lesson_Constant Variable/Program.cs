//本程序中包含以下内容:
//1.C#中的常量： const 基本类型 = 常量值
//   为什么用常量？比如一些固定值，比如圆周率PAI，用常量来保存不容易发生错误，不会发生变化;可重复调用
//2.C#中常量的命名规范：所有字母均大写

internal class Program
{ 
    const double PI = 3.1415926;   //定义常量圆周率
    private static void Main(string[] args)
    {
        Console.WriteLine(CalculateCircle(2.5));
    }

    static double CalculateCircle(double r)
    {
        return r * r * PI; //其中PI是常量，全都大写在代码阅读上很方便
    }
}