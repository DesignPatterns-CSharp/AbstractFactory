using System;

namespace AbstractFactory.Interface
{
    public class Bmw528 : ICar
    {
        void ICar.Start()
        {
            Console.WriteLine("BMW 528 Starts");
        }

        void ICar.Stop()
        {
            Console.WriteLine("BMW 528 Stops");
        }
    }
}
