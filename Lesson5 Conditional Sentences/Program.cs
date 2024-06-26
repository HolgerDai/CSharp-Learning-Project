//本程序中包含以下内容
//1.C#中的If条件语句写法为，if(条件){}，不需要endif
//2.


internal class Program
{
    private static void Main(string[] args)
    {
        //成绩判断程序
        Console.WriteLine("请输入成绩，程序会自动进行等级判断:");
        int score = Convert.ToInt32(Console.ReadLine());

        //C#中，if条件语句的写法为，if(条件){}
        if (score >= 90)
        {
            Console.WriteLine("A");
        }
        else if (score >= 80)
        {
            Console.WriteLine("B");
        }
        else if(score >= 70)
        {
            Console.WriteLine("C");
        }
        else if(score >= 60)
        {
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("E");
        }
    
    }
    
}