using System;

namespace AbstractFactory.Interface
{
    public class Bmw720 : ICar
    {
        void ICar.Start()
        {
            Console.WriteLine("BMW 720 Starts");
        }

        void ICar.Stop()
        {
            Console.WriteLine("BMW 720 Stops");
        }
    }
}
