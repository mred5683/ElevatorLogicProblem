using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorLP.Core.Interfaces
{
    public interface IRider
    {
        int RiderId { get; set; }
        int[] FloorVisitingPlan { get; set; }
        int CurrentFloor { get; set; }
        int HourOfArrival { get; set; }
        int HourOfDeparture { get; set; }
        int HourOfFloorTraverse { get; set; }
        Building Building { get; }

        void SignalElevator(ElevatorDirection upOrDown);
        int SelectFloor();
        void ArriveToWork();
        void DepartFromWork();
        void SetFloorVisitPath();
    }
}
