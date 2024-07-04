//本程序中包含以下内容
//1.C#中while循环的写法：while(条件){循环体}
//2.C#中for循环的写法: for(初始化;条件表达式;增量表达式){循环体}
//      for循环语句执行前，先执行初始化代码，然后进行循环条件判断，循环体执行结束后，进行增量表达式
//3.C#中do-while循环的写法:do{循环体}while(条件)
//      do-while和while区别：当⾸次进⼊循环不满⾜条件表达式的时候，dowhile会执⾏⼀次循环体，while⼀次都不会执⾏
//      某些场合，使用do-while会让代码看上去比while更简洁，比如先要得到一次用户输入进行判断再做循环、循环中要求用户再输入的情况
//*Break语句可以跳出离它最近的循环
//*Continue语句，可以中止目前的循环，跳转到下次循环判断
//4.C#中，定义在循环或者条件里的变量，只作用于这个循环或条件内，为局部变量，括号内为其作用域
//      ⽗作⽤域与⼦作⽤域，可以访问⽗作⽤域⾥⾯的变量，但是⽗作⽤域不能访问⼦作⽤域⾥⾯的变量

using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        //输入一个整数，计算1+2+3+...n的和
        Console.WriteLine("请输入一个整数:");
        int number = Convert.ToInt32(Console.ReadLine());
        int startWhile = 1;
        int resultWhile = 0;
        //C#中 While语句的写法：while(条件){循环体}
        while (startWhile <= number)
        {
            resultWhile = resultWhile + startWhile;
            startWhile++;
        }
        Console.WriteLine("用While循环执行、最后的结果为:{0}",resultWhile);

        //C#中for循环的写法: for(初始化;条件表达式;增量表达式){循环体}
        int resultFor = 0;
        for (int i = 0; i <= number; i++)
        {
            resultFor = resultFor + i;
        }
        Console.WriteLine("用While循环执行、最后的结果为:{0}", resultFor);

        //do-while和while区别：当⾸次进⼊循环不满⾜条件表达式的时候，dowhile会执⾏⼀次循环体，while⼀次都不会执⾏
        int test = 0;
        do
        {
            Console.WriteLine("测试Do While");
        } while (test > 0);
    
        //测试作用域
        for(int j= 0; j <= number; j++)
        {
            Console.WriteLine(j);
        }
        //可反注释下图代码，会报错，原因是变量j是局部变量，作用域仅为上图循环，循环结束后内存已回收
        //Console.WriteLine(j);
    }     

}