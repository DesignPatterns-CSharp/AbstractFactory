using System;

namespace AbstractFactory.Interface
{
    public class BmwZ4 : ICar
    {
        void ICar.Start()
        {
            Console.WriteLine("BMW Z4 Starts");
        }

        void ICar.Stop()
        {
            Console.WriteLine("BMW Z4 Stops");
        }
    }
}
