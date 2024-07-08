//本程序中包含以下内容:
//1.C#中函数的重载：函数名相同，参数不同，编译器会根据你传递过来的实参的类型去判定调⽤哪⼀个函数
//  举个例子比如：下面两个求和函数，函数名一样，但是返回值和返回类型不同，
//               编译器会根据你实际传了int还是double的数组来调用哪个函数
//  1.static int AddValue(int[] intArray){...}
//  2.static double AddValue(double[] doubleArray){...}
//*跟返回值什么类型无关，调用哪个函数，编译器只看函数名和传入参数类型

using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(AddValue(new int[] { 1, 2, 3, 4, 5 }));      //传入的是int数组，故调用的是函数1
        Console.WriteLine(AddValue(new double[] { 1, 2.5, 4.7, 3 }));  //传入的是double数组，故调用的是函数2
    }

    //函数1
    static int AddValue(int[] intArray) 
    {
        int result = 0;
        foreach (int i in intArray) {
            result += i;
        }
        return result;
    }

    //函数2
    static double AddValue(double[] doubleArray) {
        double result = 0;
        foreach (double i in doubleArray)
        {
            result += i;
        }
        return result;
    }

}