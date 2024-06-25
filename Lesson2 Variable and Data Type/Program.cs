//本程序中包含以下内容
//1.C#中变量的申明方法 数据类型 + 变量名
//2.C#中数据类型
//  int 整型 double 浮点型 char 字符型(注意C#中，char的赋值必须用单引号)
//3.字符型与对应的ASCII码，比如a对应77
//*声明一个整型存放ASCll码，可强制转换为char型赋值给char 强转:(char)

internal class Program
{
    private static void Main(string[] args)
    {
        //1.C#中变量的申明方法 数据类型 + 变量名
        int age1;       //无初始化值
        int age2 = 27;  //有初始化值
        //Console.WriteLine(age1); 反注释后可发现，未被赋值的变量无法输出，语法检查会报错
        Console.WriteLine(age2);

        //整型
        int age3,age4;
        age3 = 27;
        age4 = 28;
        
        //浮点型
        double average;
        average = (age3 + age4)/2;
        Console.WriteLine(average);

        //字符型
        char name1, name2, name3;
        name1 = 'D';
        name2 = 'A';
        name3 = 'I';
        Console.WriteLine(name1+name2+name3);

        //字符型与ASCll码的关系
        //将一个字符，赋值给一个int型变量，输出的是这个字符的ASCll码
        int TestASCll = 'a';
        Console.WriteLine(TestASCll);

        //*声明一个整型存放ASCll码，可强制转换为char型赋值给char
        int num = 97;
        char chara = (char)num;
        Console.WriteLine(chara);

    }
}