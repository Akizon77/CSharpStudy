using System.Diagnostics;

namespace Program // 命名空间 空间的名称自己命
{
    class App // 类 类的名称自己定
    {
        /* 函数的组成：
         * 1.修饰符 下面Main函数的修饰符是 public 和 static
         *   一个函数可以有多个修饰符
         * 2.返回类型 本例是void，可以是所有类型，包括int等简单类型和Key等复杂类型
         * 3.函数名称 下面的函数名称是 Main
         * 4.函数的参数列表 
         * 5.参数列表可以是包含多个参数 
         * 6.本函数只有一个参数 参数类型是 string[] 参数名称是 args
         * 7.名称为 Main 且有 static 修饰的函数将作为程序的起始点
         *   系统会在程序启动之后执行Main函数里的代码
         *   你之前没有声明函数直接开始写代码是因为
         *   系统识别到没有Main函数，而里面的代码可以直接执行
         *   帮你套了一个Main函数（C#特有，其他函数型语言没有这个特性）
         * 8.可以在函数里声明函数 
         */
        /* 函数内部可以：
         * 1.声明局部变量 int x = 0;
         * 2.控制语法 if ( x > 5) { ... }
         * 3.方法调用 Math.Sqrt(2);
         * 4.内嵌 {...}
         * 4.声明局部函数 void Function(){...}
         */
        public static void Main(string[] args)
        {
            //在函数里声明函数
            /* 没有修饰
             * 不返回数据（返回类型void，void是空白，也就是不返回）
             * 名称是MyFunction
             * 不需要参数
             */
            void MyFunction()
            {
                Debugger.Break();
            }
            /* 没有修饰
             * 返回int数据
             *   返回数据的函数必须使用 return 返回数据（进阶：或者throw抛出异常）
             * 名称是Sum
             * 参数有两个
             */
            int Sum(int x,int y)
            {
                return x + y;
            }
            /* 还记得Math.Sqrt这个函数不？
             * 使用函数很简单，(函数所在的类.)函数名(...参数)
             * Eg：Math.Sqrt(2);
             *     Console.WriteLine("Hello");
             *     Sum(1,2);
             * 上面三个例子中，Sqrt和WriteLine前有类名
             * 而Sum不需要，因为Sum函数和当前Main函数处在同一个类（第5行）
             * 在VS中 将光标移动到函数名称上按F12可以查看这个函数的内容
             */
            int x = Sum(1, 2);
            double y = MyClass.Sqrt(6);

        }
    }
    class MyClass
    {
        public static double Sqrt(double x)
        {
            return Math.Sqrt(x);
        }
    }
}
//你好！