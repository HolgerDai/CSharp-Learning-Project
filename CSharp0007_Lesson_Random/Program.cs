//本程序中包含以下内容
//C#中随机数的使用：可以使用Random对象, .Next方法可以得到随机数

internal class Program
{
    private static void Main(string[] args)
    {
        Random rd = new Random();       //初始化rd对象
        int number1 = rd.Next();         //.Next方法可以得到随机数
        int number2 = rd.Next(1, 100);    //.Next方法还可以明确随机数的范围
        Console.WriteLine(number1);
        Console.WriteLine(number2);

        //猜数字
        while (true)
        {
            Console.WriteLine("猜猜系统生成的随机数(1-100),请输入你的数字:");
            int guessNum = Convert.ToInt32(Console.ReadLine());
            if (guessNum > number2)
            {
                Console.WriteLine("猜大了");
            }
            else if (guessNum < number2)
            {
                Console.WriteLine("猜小了");
            }
            else
            {
                Console.WriteLine("猜对了");
                break;
            }
        }
    }
}