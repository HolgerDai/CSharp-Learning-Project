//本程序中包含以下内容
//C#中的函数(或者称方法)
//  什么时候需要写函数？ - 当重复使用某段代码时，后续便于更新功能
//  函数的定义方法 返回类型 函数名(类型 形式参数名1, 类型 形式参数名2)
//      1.如果没有返回值，则返回类型为void
//      2.如果有返回值，则函数内部需要用return返回值，调用的地方可选择接收返回值或不接受,一旦Return了，后续代码就不执行了
//      3.形式参数根据需要进行定义，可有可无，但是定义了要有形式参数，则需要调用时传递实际参数到形式参数（参数数组例外，见Lesson11）
internal class Program
{
    //这是Main函数，是主方法、入口方法
    //其他函数需要定义在Main函数之外
    private static void Main(string[] args)
    {
        int num1 = 5;
        int num2 = 29;
        AddInt1(num1, num2);                //传入函数的，num1和num2被称为实际参数
        int result = AddInt2(num1, num2);    //函数有返回值，并接收返回值
        AddInt2(num1, num2);       //函数有返回值，但也可以选择不接收，不会报错
        Console.WriteLine(result);
    }

    //有返回值的函数
    //static称为静态方法，属于修饰符，后续类中介绍
    //void代表此函数，无返回值
    //inputNum1,input Num2为此函数传递进来的形式参数,若没有形参，可以为空
    static void AddInt1(int inputNum1 , int inputNum2)
    {
        Console.WriteLine(inputNum1 + inputNum2); 
    }

    //无返回值函数的写法
    //bool代表此函数执行结果需要返回一个bool值
    //用return来返回结果, 此外,一旦Return了，后续代码就不执行了
    static int AddInt2(int inputNum1, int inputNum2)
    {
        return(inputNum1 + inputNum2);
        Console.WriteLine("Test");
    }


}