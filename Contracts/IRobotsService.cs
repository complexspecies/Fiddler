using Fiddler.Models;

namespace Fiddler.Contracts
{
    public interface IRobotService
    {
        Robot BuildRobot(List<Parts> parts);
    }
}
