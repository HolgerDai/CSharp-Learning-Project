//本程序中包含以下内容
//1.C#中的数学运算符，加+、减-、乘*、除/、取余数%
//  注意：被除数与除数都是整数时，结果会自动舍去小数点部分
//2.C#中的赋值运算符，简单赋值=；
//  此外还有+=，这种复合赋值与运算的，A += B 等同于 A = A + B
//3.C#中的自增自减符++ -- 
//  注意区分a++与++a，a++是：先赋值再自增；++a是：先自增再赋值
//4.C#中的关系运算符，==,>,!=等，返回的结果为Bool型
//5.C#中的逻辑运算符 &&(and) ||(or) !(非)
//6.注意程序中的运算优先级
//  不同类型运算符之间是有优先级的，比如数学运算符计算优先级高于逻辑运算符。
//  同类型运算符内部，不同运算符号也是有优先级的，特别经典的是 &&(and)优先级高于||(or)
//  若要自定义优先级，可加()，程序优先处理括号内的计算


using System.Security.Principal;

internal class Program
{
    private static void Main(string[] args)
    {
        //注意：被除数与除数都是整数时，结果会自动舍去小数点部分
        int a = 45 / 10;
        System.Console.WriteLine(a); //结果为4

        double b = 45 / 10;
        System.Console.WriteLine(b); //结果为4

        double c = 45 / 10.0;
        System.Console.WriteLine(b); //结果为4.5

        //A += B 等同于 A = A + B
        int d = 0;
        int e = 1;
        e += d; //等同于 e = e + d
        System.Console.WriteLine(e); //结果为1

        //a++，是先赋值再自增
        int f = 1;
        System.Console.WriteLine(f++);  //1
        System.Console.WriteLine(f);    //2

        //++a，是先自增再赋值
        int g = 1;
        System.Console.WriteLine(++g);  //2
        System.Console.WriteLine(g);    //2

        //关系运算，返回的结果为Bool型
        bool bool1 = 1 > 2;  //False
        System.Console.WriteLine(bool1);

        bool bool2 = 2 != 3; //True
        System.Console.WriteLine(bool2);

        //逻辑运算符and &&
        System.Console.WriteLine(bool1 && bool2);
        //逻辑运算符or ||
        System.Console.WriteLine(bool1 || bool2);
        //逻辑运算符非 ！
        System.Console.WriteLine(!bool1);

        //证明 && 优先级高于 ll
        bool bool3 = false;
        System.Console.WriteLine(bool2 || bool1 && bool3);  //true ll false && false = true

        //证明()内先运行
        System.Console.WriteLine((bool2 || bool1) && bool3);  //(true ll false) && false = false
    }
}