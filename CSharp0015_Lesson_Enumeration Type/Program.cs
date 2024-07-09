//本程序中包含以下内容:

//枚举类型使用方法：
//1.定义集合: enum 集合名{ 常量 , 常量 , 常量 = int值, ... } 允许对常量进行int赋值，不然默认为0,1,2....;
//2.参考定义的集合名，声明枚举类型变量: 集合名 变量名;
//3.枚举类型变量的赋值：变量名 = 集合名.常量

//1.C#中的枚举是什么？-是一个被命名的常数的集合。-例如，一个星期内只有七天，一年只有十二个月，游戏中特定的七个职业等
//2.C#中的枚举有什么作用？ -便于限制变量的可变值，且在代码阅读时可随时知道当前为什么值
//3.C#中是否可以用int来取代枚举？
//     可以用int来取代
//     优点：运行效率快，
//     缺点：需要在程序外记录每个int值对应的真正含义是什么，多成员开发时沟通时间增加，且在代码中不易理解和阅读
//4.C#中，其实枚举类型存储的时候，是按照int来存储的，比如鼠标移到下面的Mage，Archer，会发现Mage = 0，Archer=1。但枚举类型方便在使用的时候可直接用字符串。
//5.关于第4点的延申，如何取得枚举类型对应的整数？可使用（int）强转
//6.关于第4点的延申，在定义枚举类型的集合时，可以修改存储的int的



internal class Program
{
    //枚举的定义
    //定义了一个叫RoleType的集合

    enum RoleType
    {
        Mage,Archer,Assassin
    }

    //定义枚举类型的集合时，可以修改存储的int值
    enum WeekDays
    {
        Monday, Tuesday, Wednesday=10, Friday, Saturday, Sunday
    }

    private static void Main(string[] args)
    {
        //比如，开发一个RPG游戏，有不同角色，法师、战士、刺客等；如果用int来存储 1.法师、2.战士 3.刺客
        //int roleType1;
        //roleType1 = 1;   //代码里仅仅写了roleType=1，不知道实际是什么含义，需要系统外沟通才知道是法师

        RoleType roleType2;             //声明一个枚举类型的变量，且参考RoleType集合
        roleType2 = RoleType.Mage;      //用枚举便于代码阅读，且限制可变值必须在RoleType集合
        
        WeekDays weekDays;              //声明了一个枚举类型的变量，且参考的是WeekDays来声明的
        weekDays = WeekDays.Monday;     //该变量赋值了Monday
        weekDays = WeekDays.Tuesday;    //该变量换成了Tuesday

        Console.WriteLine((int)weekDays);   //可使用（int）强转得到对应值，输出结果为1，因为Tuesday后台对应的int为1

        weekDays = WeekDays.Wednesday;
        Console.WriteLine((int)weekDays);   //Wednesday在集合定义里，赋值了10，所以输出结果为10

    }
}