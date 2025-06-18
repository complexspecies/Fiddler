using Fiddler.Contracts;
using Fiddler.Models;

namespace Fiddler.Services
{
    public class CarService : ICarService
    {
        public Car BuildCar(List<Parts> parts) => new Car();
    }
}
