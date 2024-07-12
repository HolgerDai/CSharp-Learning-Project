//本程序中包含以下内容:
//通过实际的一个模拟例子，来理解为什么要用委托
//假定场景，有一个游戏开发组，组员A负责写角色相关功能，组员B负责写UI,菜单相关功能

//问题点：实际开发时，每个人开发自己的模块，但因为大家是分开电脑各自编写模块，无法直接调用其他人写的模块
//解决方法：可以用委托来解决，将其他人开发的模块作为委托类型的形参，自己开发时调用这个委托

using Microsoft.Win32.SafeHandles;

internal class Program
{
    //玩家A定义一个委托出来
    delegate void OnDieDelegate();

    //玩家A正在写角色相关代码
    static void Play(OnDieDelegate onDie)  //申明一个委托类型变量在传参，参考OnDieDelegate来声明
    {
        Console.WriteLine("玩家正在做任务");
        Console.WriteLine("玩家正在战斗");
        Console.WriteLine("玩家已死亡");
        //此时应跳出死亡后的UI界面，需调用玩家B写的UI，如下
        //注意：往往实际项目中，因为大家是分开两个电脑编写模块，此时其实A电脑上是没ShowDieUI的，所以A无法这么写
        //ShowDieUI();  A无法这么写 

        //此时，A如果想要调用未来B写的东西，就可以使用委托的方法了，有点类似接口
        //由于委托是一个变量，可将此函数加一个传入委托类型的形参，直接调用主函数传入的委托就可以了，可直接调用
        onDie();
    }

    //玩家B正在写UI相关代码
    static void ShowDieUI() 
    {
        Console.WriteLine("显示游戏死亡后的UI");
        Console.WriteLine("返回首页UI");
    }

    private static void Main(string[] args)
    {
        // Play();
        //在主程序中，将B开发好的UI模块传给A
        Play(ShowDieUI);
    }
}