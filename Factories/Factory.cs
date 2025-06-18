using Fiddler.Contracts;
using Fiddler.Models;
using Fiddler.Services;

namespace Fiddler.Factories
{
    public class Factory
    {
        private readonly IPartsService _partsService;
        private readonly Dictionary<Type, object> _builders;

        public Factory(IPartsService partsService, IRobotService robotService, ICarService carService)
        {
            _partsService = partsService;
            _builders = new Dictionary<Type, object>
        {
            { typeof(Robot), new RobotBuilder(robotService) },
            { typeof(Car), new CarBuilder(carService) }
        };
        }

        public T BuildVehicle<T>(Enum vehicleType) where T : class
        {
            var parts = _partsService.GetParts(vehicleType);
            if (_builders.TryGetValue(typeof(T), out var builder))
            {
                // Cast to the specific builder interface
                var typedBuilder = builder as IVehicleBuilder<T>;
                return typedBuilder?.Build(parts);
            }
            return null;
        }
    }
}
