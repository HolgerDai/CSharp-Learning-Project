//本程序中包含以下内容
//C#中的参数数组：
//为什么要用参数数组？ -比如解决这个问题：定义一个函数，用来取得数字的和，但是数字的个数不确定。
// 解决方案1：定义一个函数，参数传递过来一个数组；（传递进来的必须是数组）
// 解决方案2：定义一个参数个数不确定的函数，这个时候可以使用参数数组；（传递进来的是基本类型，函数自动构建成数组）

//方案1与方案2的区别：传参时，方案1必须我们构造数组；方案2，系统可以为你构造数组

//注意点1：参数数组为可传可不传的参数，除了参数数组外，其他参数在调用时一定要传递值
//注意点2：参数数组只能有一个，和其他参数搭配使用时，必须放在最后一个（这个规定，便于程序收集哪些参数需成为参数数组）


internal class Program
{
    private static void Main(string[] args)
    {
        int result1, result2, result3, result4, result5,result6;
        //调用两数求和函数
        result1 = AddWay1(2, 3);

        //调用不确定数字个数求和函数方法1：传入数组
        //以下这种写法会报错，因为程序不认为{1，2，3，4}是数组对象，需要New一个数组对象并赋值；
        //result2 = AddWay2({1,2,3,4});
        //result2 = AddWay2(20, 231);
        //正确写法：
        result2 = AddWay2(new int[] {33,27,100,25});

        //实现不确定数字个数求和函数方法2：参数数组
        result3 = AddWay3(22, 50, 32, 32);
        result4 = AddWay3(23, 988, 902, 1, 20, 15);    //可传递任意个数参数，函数会自动合并为数组
        result5 = AddWay3(new int[] { 20, 15, 333 });  //当然，也可以直接接收数组
        //result6 = AddWay5(20, 30, 59);               //参数数组和其他参数搭配使用时，其他参数在调用时一定要传递值
        result6 = AddWay5("Test", 20, 30, 59);

        Console.WriteLine(result1);
        Console.WriteLine(result2);
        Console.WriteLine(result3);
        Console.WriteLine(result4);
        Console.WriteLine(result5);
        Console.WriteLine(result6);

    }

    //两数求和函数
    //局限性：必须只能传入两个参数
    static int AddWay1(int a, int b)
    {
        return a + b; 
    }

    //实现不确定数字个数求和函数方法1：传入数组
    //局限性：
    //1.必须传递进来的时候，是一个数组对象
    //2.调用的时候，也必须先有数组对象，对数组对象赋值后，进行传参
    static int AddWay2(int[] a)
    {
        int result = 0;
        foreach (int temp in a)
        {
            result += temp;
        }
        return result;
    }


    //实现不确定数字个数求和函数方法2：参数数组
    //优点1.可以传递任意个数的参数进来，函数会自动构建成数组
    //优点2.也接收数组

    static int AddWay3(params int[] a)
    {
        int result = 0;
        foreach (int temp in a)
        {
            result += temp;
        }
        return result;
    }

    //参数数组只能有一个，和其他参数搭配使用时，必须放在最后一个
    //下面这个写法会报错，因为参数数组不在最后
    //static void AddWay4(params int[] a,string b)
    //{
    //}

    //除了参数数组外，其他参数在调用时一定要传递值
    static int AddWay5(string b,params int[] a)
    {
        int result = 0;
        foreach (int temp in a)
        {
            result += temp;
        }
        Console.WriteLine(b);
        return result;
    }

}