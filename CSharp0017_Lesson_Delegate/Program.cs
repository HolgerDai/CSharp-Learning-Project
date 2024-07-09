//本程序中包含以下内容:
//1.C#中的委托：是⼀种存储函数引⽤的类型。
//  简单来说，如果有返回参数与传入参数相同的函数，可以定义一个委托对象，去指向任意函数，可使用委托来执行该函数
//需要注意的是：
//  1.委托需要先定义，后申明，然后赋值指向的函数，最后才能使用
//  2.委托的返回值和传参，必须和未来要指向函数的返回值传参类型一致才行

//个人理解：委托可以理解为，创建一个变量可以用来根据条件切换指向函数，可以让代码更灵活

internal class Program
{
    //两数相乘函数
    static double Multiply(double a, double b)
    {
        return a * b;
    }

    //两数相除函数
    static double Divide(double a, double b)
    {
        return a / b; 
    }

    //由于两数相乘函数与相除函数参数等一致，可以定义一个delegate，用于后续创建对象指向他们
    //注意返回值和传参要一致
    delegate double TwoNumberCalculation(double a, double b);
    private static void Main(string[] args)
    {
        TwoNumberCalculation twoNumberCalculation;          //声明委托对象
        twoNumberCalculation = Multiply;                    //赋值委托对象函数名，此时此对象指向两数相乘
        Console.WriteLine(twoNumberCalculation(5.0,22.3));
        twoNumberCalculation = Divide;                      //赋值委托对象函数名，此时此对象指向两数相乘
        Console.WriteLine(twoNumberCalculation(20, 4));

    }
}