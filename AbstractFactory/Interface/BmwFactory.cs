namespace AbstractFactory.Interface
{
    public class BmwFactory : IAbstractFactory
    {
        public ICar Convertible()
        {
            return new BmwZ4();
        }

        public ICar Luxury()
        {
            return new Bmw720();
        }

        public ICar Sedan()
        {
            return new Bmw528();
        }
    }
}
