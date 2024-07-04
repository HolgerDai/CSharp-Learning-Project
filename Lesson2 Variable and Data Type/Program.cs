//本程序中包含以下内容
//1.C#中变量的申明方法 数据类型 + 变量名
//2.C#中数据类型
//  int 整型（默认32位） double 浮点型 char 字符型(注意C#中，char的赋值必须用单引号) bool 布尔类型(输出为True/False)
//  C#中每个数据类型都有默认大小的，比如int为32位，则可以赋值的范围为：-2147483648~2147483647(其他类型可百度搜索)
//3.字符型与对应的ASCII码，比如a对应77
//*声明一个整型存放ASCll码，可强制转换为char型赋值给char 强转:(char)

//*Decimal类型常用于货币，后面会介绍

//命名规范：
//变量使用驼峰命名法，当变量为单词合并组成时，第一个单词首字母小写，其他单次首字母大写，比如：myAge；
//类和方法使用Pascal命名法，即每一个单词首字母都大写

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

        //布尔类型
        bool testBool1 = true;
        bool testBool2 = false;
        Console.WriteLine(testBool1);
        Console.WriteLine(testBool2);

    }
}