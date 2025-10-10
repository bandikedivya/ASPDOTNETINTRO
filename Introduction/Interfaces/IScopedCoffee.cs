using Microsoft.AspNetCore.Http.HttpResults;
using static System.Net.WebRequestMethods;

namespace Introduction.Interfaces
{

    //AddScoped: one instance is created per HTTP request / scope, reused within that request
    public interface IScopedCoffee
    {
        string GetCoffeeId();
    }
}
