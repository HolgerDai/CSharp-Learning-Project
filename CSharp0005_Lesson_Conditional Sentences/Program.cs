//本程序中包含以下内容
//1.C#中的if条件语句写法为，if(条件){}，不需要endif
//2.C#中的switch条件语句的写法为，switch(变量){ case X: +break default}，默认判断相等
//  switch中，除了case，还有default，类似else
//  注意, switch条件语句中要记得加break

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
        else if (score >= 70)
        {
            Console.WriteLine("C");
        }
        else if (score >= 60)
        {
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("E");
        }

        //饮料机售货程序
        Console.WriteLine("请输入您想购买的饮料编号:");
        int waterId = Convert.ToInt32(Console.ReadLine());

        //C#中，switch条件语句的写法为，switch(变量){ case X: +break},默认判断相等
        switch (waterId)
        {
            case 1:
                Console.WriteLine("矿泉水");
                break;
            case 2:
                Console.WriteLine("雪碧");
                break;
            case 3:
                Console.WriteLine("可乐");
                break;
            //这种情况，4、5都会输出橙汁
            case 4:
            case 5:
                Console.WriteLine("橙汁");
                break;
            default:
                Console.WriteLine("没有您要购买的商品");
                break;
        }

    }

}