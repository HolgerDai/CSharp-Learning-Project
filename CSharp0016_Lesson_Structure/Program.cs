//本程序中包含以下内容:
//写在前面：虽然此处学习了结构体，但实际运用不多，因为C#中多用类去实现各个功能（结构体可以理解为简单版本的类，后续会介绍区别）
//1.C#中的结构体：
//  结构体的作⽤就是把某⼀类的变量进⾏整合，组成⼀个新的数据类型，相当于⼀个新的信息。
//  ⽐如学⽣信息（包含了 年龄，姓名、年级、学号）
//  定义结构体（可定义函数）：
//  struct 结构体名{
//             访问权限 基本类型 变量名 
//             访问权限 基本类型 变量名
//             ...
//             访问权限 函数                
//          }
//2.C#中的结构体数组：结构体名[]
//3.C#中的结构体函数：不用static，可以直接用结构体的变量，不用传参;必须通过结构体变量来调用

//*访问权限在后续面向对象中介绍，目前只要知道Public为公开的

internal class Program
{

    //这是对学生结构体的定义，并非申明一个变量或赋值
    struct Studentinfo
    {
        public int id;         //学号
        public string name;    //姓名
        public int grade;      //年纪
        public int age;        //年龄
    }

    //坐标位置结构的定义
    //需实现打印位置的功能，有两个方法：
    //方法1.在结构体的定义中，定义结构体函数
    struct Position
    {
        public double x; 
        public double y;
        public double z;

        //如果在结构体内定义函数
        //1.不用static
        //2.可以直接用结构体的变量，不用传参
        public void PrintPosition()
        {
            Console.WriteLine(x+" "+y+" "+z);
        }
    }

    //方法2：定义一个函数，需传入结构体参数
    static void PrintPosition(Position position)
    {
        Console.WriteLine(position.x+" "+position.y+" "+position.z);
    }
    


    private static void Main(string[] args)
    {
        //单个结构体变量
        Studentinfo student1;   //申明一个名叫student1的结构体变量
        student1.id = 1;
        student1.name = "Holger";
        Console.WriteLine(student1.name);

        //结构体数组
        Studentinfo[] studentList=new Studentinfo[10];
        for(int i=0; i < studentList.Length; i++)
        {
            studentList[i].id = i;
        }

        Position position;
        position.x = 1.5;
        position.y = 3;
        position.z = 1;

        //方法1：使用函数的方法打印坐标位置
        PrintPosition(position);

        //方法2：使用结构体函数的方法打印坐标位置
        position.PrintPosition();

    }
}