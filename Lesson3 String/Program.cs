//本程序中包含以下内容
//1.对整个字符串进行转义的方法：@"字符串"
//2.字符串的数据类型 String
//3.字符串的计算：
//  相加就是拼接 +
//4.得到用户在控制台输入的字符串 Console.ReadLine
//5.得到用户输入的字符串后，转为Int Convert.Toint32()
//6.字符串格式化输出


internal class Program
{
    private static void Main(string[] args)
    {
        //对整个字符串进行转义的方法：@"字符串"
        Console.WriteLine("1\\n2\t3\\");
        Console.WriteLine(@"1\n2\t3\\");

        //字符串的数据类型 String
        string name = "Dai Suhao";
        Console.WriteLine(name);

        //相加就是拼接 +
        string firstname = "Dai";
        string lastname = "Suhao";
        Console.WriteLine(firstname+" "+lastname);

        //得到用户在控制台输入的字符串 Console.ReadLine
        string userinput = Console.ReadLine();
        Console.WriteLine("User input: " + userinput);

        //得到用户输入的字符串后，转为Int Convert.Toint32()
        Console.WriteLine("请输入一个整数:");
        userinput = Console.ReadLine();
        int num = Convert.ToInt32(userinput);
        Console.WriteLine(num);
  
    }
}