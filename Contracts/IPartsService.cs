using Fiddler.Models;

namespace Fiddler.Contracts
{
    public interface IPartsService
    {
        List<Parts> GetParts(Enum type);
    }
}
