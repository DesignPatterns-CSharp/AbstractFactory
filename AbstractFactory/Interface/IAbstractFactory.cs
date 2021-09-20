namespace AbstractFactory.Interface
{
    public interface IAbstractFactory
    {
        ICar Luxury();

        ICar Convertible();

        ICar Sedan();
    }
}
