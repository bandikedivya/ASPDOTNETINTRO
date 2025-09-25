namespace Introduction.Interfaces;

public class CoffeeServices : ISingletonCoffee, IScopedCoffee, ITransientCoffee
{
    private readonly string _coffeeId;


    public CoffeeServices()
    {
        _coffeeId = Guid.NewGuid().ToString();
    }


    public string GetCoffeeId()
    {
        return _coffeeId;
    }
}
