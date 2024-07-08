//本程序中包含以下内容
//1.C#中数组的声明
//2.C#中数组的4个赋值方法
//3.C#中数组的索引
//4.C#中遍历数组
//      使用for while循环
//      使用foreach foreach(类型 变量名 in 数组){} 每次遍历会把一个数组值放到变量中

//2024/7/28补充
//实际使用数组，去保存一些不确定个数的计算结果时，先要去计算结果个数是多少，再进行赋值
//比如练习题：计算一个数的因子（因子：这个数能整除的数）先计算出因子个数，然后建一个因子个数大小的数组，再对数组进行赋值

internal class Program
{
    private static void Main(string[] args)
    {
        //C#中数组的声明 基本类型[] 数组名
        int[] age;
        char[] grade;
        double[] score;
        string[] name;

        //数组的赋值
        //数组不像变量一样（下面注释去掉会报错），可以等号直接赋值，有专门的写法
        //age = {1,2,3};

        //赋值方法1:声明时同时赋值
        int[] age1 = { 1, 2, 3 }; //这句话，同时赋值了数组长度为3，以及3个值

        //赋值方法2:
        int[] age2;              //先声明（但此时，长度和值都不知道）
        age2 = new int[10];      //赋值数组的长度，此时会有默认值赋值进去 int默认值为0
        Console.WriteLine(age2[0]);

        //赋值方法3:本质上赋值方法1，是方法3的简化版，数组是需要使用new的，因为数组的本质是引用类型
        int[] age3;
        age3 = new int[] { 1, 2, 3 }; //长度会默认赋值为3

        //赋值方法4：在方法3的基础上，赋值时，定义长度
        int[] age4;
        age4 = new int[3] { 1, 2, 3 };
        //指定了长度的话，必须要让长度与后面定义的值一致，下面这个会报错
        //age4 = new int[4] { 1,2,3 };

        //数组中的索引 数组名[索引] 从0开始
        Console.WriteLine(age1[0]);


        //数组的遍历，for方法
        for (int i = 0; i < age1.Length; i++)
        {
            Console.WriteLine(age1[i]);
        }

        //数组的遍历，while方法
        int i2 = 0;
        while (i2 < age1.Length)
        {
            Console.WriteLine(age1[i2]);
            i2++;
        }

        //数组的遍历，foreach方法
        foreach (int temp in age1)
        {
            Console.WriteLine(temp);
        }


    }
}