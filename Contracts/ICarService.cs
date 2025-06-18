using Fiddler.Models;

namespace Fiddler.Contracts
{
    public interface ICarService
    {
        Car BuildCar(List<Parts> parts);
    }
}
