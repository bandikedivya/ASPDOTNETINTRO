namespace Introduction.Interfaces
{

    //AddTransient means each time the service is needed, a new instance is created.
    public interface ITransientCoffee
    {
        string GetCoffeeId();
    }
}
