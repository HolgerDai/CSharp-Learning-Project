internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("请输入12个月的计划");
        string userInput = Console.ReadLine();
        string[] monthlyPlanString = userInput.Split(" ");
        int[] monthlyPlanInt = new int[12];
        int i;

        for (i = 0; i < monthlyPlanInt.Length; i++)
        {
            monthlyPlanInt[i] = Convert.ToInt32(monthlyPlanString[i]);
        }

        int currentMoney = 0;
        int totalSaved = 0;
        int thisMonthSaved = 0;
        int failedMonth = 0;
        Boolean successFlag = true;

        for (i = 0; i < 12; i++) //遍历12个月
        {
            if( currentMoney + 300 >= monthlyPlanInt[i])
            {
                thisMonthSaved = (currentMoney + 300 - monthlyPlanInt[i]) / 100 * 100;
                totalSaved = totalSaved + thisMonthSaved;
                currentMoney = currentMoney + 300 - thisMonthSaved - monthlyPlanInt[i];
            }
            else
            {
                successFlag = false;
                failedMonth = i;
                break;
            }
        }

        if ( successFlag == true)
        {
            totalSaved = Convert.ToInt32(totalSaved*1.2 + currentMoney);
            Console.WriteLine(totalSaved);
        }
        else
        {
            Console.WriteLine("-{0}", failedMonth + 1);
        }

    }
}