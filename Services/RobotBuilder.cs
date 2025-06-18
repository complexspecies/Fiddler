using Fiddler.Contracts;
using Fiddler.Models;

namespace Fiddler.Services
{
    public class RobotBuilder : IVehicleBuilder<Robot>
    {
        private readonly IRobotService _robotService;

        public RobotBuilder(IRobotService robotService)
        {
            _robotService = robotService;
        }

        public Robot Build(List<Parts> parts) => _robotService.BuildRobot(parts);
    }
}
