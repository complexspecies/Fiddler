using Fiddler.Contracts;
using Fiddler.Models;

namespace Fiddler.Services
{
    public class CarBuilder : IVehicleBuilder<Car>
    {
        private readonly ICarService _carService;

        public CarBuilder(ICarService carService)
        {
            _carService = carService;
        }

        public Car Build(List<Parts> parts) => _carService.BuildCar(parts);
    }
}
