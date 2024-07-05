//本程序中包含以下内容
//1.对整个字符串进行转义的方法：@"字符串"
//2.字符串的数据类型 String
//3.字符串的计算：
//  相加就是拼接 +
//4.得到用户在控制台输入的字符串 Console.ReadLine
//5.得到用户输入的字符串后，转为Int Convert.Toint32()
//6.字符串格式化输出，替代标记用大括号索引 Console.WriteLine("{0},{1},{2}",a,b,c)
//学完Lesson8后补充：
//7.字符串可以理解为字符数组，一些数组的操作可以用于字符串（参见Lesson8 Array）比如可以用.Length和索引
//      当想要把string赋值给字符数组时，对string使用.ToCharArray()，即可赋值
//      此外，String本身，可以建一个string类型的数组，string[]
//8.字符串的常用操作
//      1)大小写转换:ToLower(),ToUpper() 使用场景：验证码，用户只要输对就行，不管大小写
//      2)去空格：Trim() 使用场景：用户输入的用户名，多输入了空格
//      3)当已知分割符时分割字符串：string[] strlist = namelist.Split(";") 主要要用String数组去接收结果

internal class Program
{
    private static void Main(string[] args)
    {
        //对整个字符串进行转义的方法：@"字符串"
        //Console.WriteLine("1\\n2\t3\\");
        //Console.WriteLine(@"1\n2\t3\\");

        //字符串的数据类型 String
        string name = "DaiSuhao";
        Console.WriteLine(name);

        //相加就是拼接 +
        string firstname = "Dai";
        string lastname = "Suhao";
        Console.WriteLine(firstname + " " + lastname);

        //得到用户在控制台输入的字符串 Console.ReadLine
        Console.WriteLine("请输入任意字符串:");
        string userinput = Console.ReadLine();
        Console.WriteLine("User input: " + userinput);

        //得到用户输入的字符串后，转为Int Convert.Toint32()
        Console.WriteLine("请输入一个整数:");
        userinput = Console.ReadLine();
        int num = Convert.ToInt32(userinput);
        Console.WriteLine(num);

        //字符串格式化输出,用大括号索引
        char a = 'a';
        char b = 'b';
        string c = "test";
        Console.WriteLine("{0},{1},{2}", a, b, c);

        //字符串可以当成字符数组，进行数组操作
        for (int i = 0; i < name.Length; i++)
        {
            Console.WriteLine(name[i]);
        }

        //当想要把string赋值给字符数组时(一般字符数组用于对单个字符操作)，对string使用.ToCharArray()，即可赋值
        char[] charArray;
        charArray = name.ToCharArray();

        //string本身，可以建一个string类型的数组，string[]
        string[] namelist1 = { "12fjdks3", "131dsa23", "213dsajk" };

        //8.字符串的常用操作
        //大小写转换（常用于验证码）:
        string str1 = name.ToLower();
        string str2 = name.ToUpper();
        Console.WriteLine(name);
        Console.WriteLine(str1);
        Console.WriteLine(str2);

        //去空格（常用于用户名）:
        string name2 = " Dai Su hao ";
        string str3 = name2.Trim();      //Trim()会去掉字符串前面以及后面的空格
        string str4 = name2.TrimStart(); //TrimStart()会去掉字符串前面的空格
        string str5 = name2.TrimEnd();   //TrimEnd()会去掉字符串后面的空格
        Console.WriteLine(name2);
        Console.WriteLine(str3);
        Console.WriteLine(str4);
        Console.WriteLine(str5);

        //当已知分割符时分割字符串
        string namelist = "test1;test2;test3";
        string[] strlist = namelist.Split(";");  //用string类型的数组，去接收Split的结果
        foreach (string str in strlist)
        {
            Console.WriteLine(str);
        }
    }
}