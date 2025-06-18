using Fiddler.Models;

namespace Fiddler.Contracts
{
    public interface IVehicleBuilder<T>
    {
        T Build(List<Parts> parts);
    }
}
