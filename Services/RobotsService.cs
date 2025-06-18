using Fiddler.Contracts;
using Fiddler.Models;

namespace Fiddler.Services
{
    public class RobotService : IRobotService
    {
        public Robot BuildRobot(List<Parts> parts) => new Robot();
    }
}
