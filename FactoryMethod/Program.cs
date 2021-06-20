using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //读《设计模式之禅》之工厂方法 DEMO 实现 
            Console.WriteLine("-- 女娲造人!工厂方法 DEMO --");

            #region 简单工厂方法调用

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

            #endregion

            #region 多工厂方法调用


            Console.WriteLine("\n-- 造出的第一批人是白种人 (多工厂实现) --");
            Human whiteHuman2 = new WhiteHumanFactory().CreateHuman();
            whiteHuman2.GetColor();
            whiteHuman2.Talk();

            Console.WriteLine("\n-- 造出的第二批人是黑种人 (多工厂实现)--");
            Human blackHuman2 = new BlackManFactory().CreateHuman();
            blackHuman2.GetColor();
            blackHuman2.Talk();

            Console.WriteLine("\n-- 造出的第三批人是黄种人 (多工厂实现)--");
            Human yellowHuman2 = new YellowHumanFactoryFactory().CreateHuman();
            yellowHuman2.GetColor();
            yellowHuman2.Talk();

            #endregion


            Console.ReadKey();

        }
    }
}
