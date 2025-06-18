using Fiddler.Contracts;
using Fiddler.Models;

namespace Fiddler.Services
{
    public class PartsService : IPartsService
    {
        public List<Parts> GetParts(Enum type) => new List<Parts> { new Parts() };
    }
}
