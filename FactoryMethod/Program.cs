using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //读《设计模式之禅》之工厂方法 DEMO 实现 
            Console.WriteLine("-- 女娲造人!工厂方法 DEMO --");

            //女娲第一次造人，火候不足，于是白人产生了
            Console.WriteLine("\n-- 造出的第一批人是白种人 --");
            Human whiteHuman = new HumanFactory<WhiteHuman>().CreateHuman();
            whiteHuman.GetColor();
            whiteHuman.Talk();

            //女娲第二次造人，火候过足，于是黑人产生了
            Console.WriteLine("\n-- 造出的第二批人是黑种人 --");
            Human blackHuman = new HumanFactory<BlackMan>().CreateHuman();
            blackHuman.GetColor();
            blackHuman.Talk();

            //第三次造人，火候刚刚好，于是黄色人种产生了
            Console.WriteLine("\n-- 造出的第三批人是黄种人 --");
            Human yellowHuman = new HumanFactory<YellowHuman>().CreateHuman();
            yellowHuman.GetColor();
            yellowHuman.Talk();

            Console.ReadKey();

        }
    }
}
