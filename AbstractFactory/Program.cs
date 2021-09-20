using AbstractFactory.AbstractClass;
using AbstractFactory.Interface;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            #region AbstractClass
            // Create and run the African animal world
            ContinentFactory africa = new AfricaFactory();
            AnimalWorld world = new AnimalWorld(africa);
            world.RunFoodChain();

            // Create and run the American animal world
            ContinentFactory america = new AmericaFactory();
            world = new AnimalWorld(america);
            world.RunFoodChain();
            #endregion


            #region Interface
            BmwFactory bmwFactory = new BmwFactory();

            //*********************************************
            var convertible = bmwFactory.Convertible();
            convertible.Start();
            convertible.Stop();

            Console.WriteLine("-------------------------");
            //*********************************************

            //*********************************************
            var luxury = bmwFactory.Luxury();
            luxury.Start();
            luxury.Stop();

            Console.WriteLine("-------------------------");
            //*********************************************

            //*********************************************
            var sedan = bmwFactory.Sedan();
            sedan.Start();
            sedan.Stop();
            #endregion
            Console.ReadKey();
        }
    }
}
