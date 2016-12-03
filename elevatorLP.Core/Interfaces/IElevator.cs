using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorLP.Core.Interfaces
{
    public interface IElevator
    {
        string ElevatorId { get; set; }
        int NumberOfRiders { get; set; }
        int CurrentFloorNumber { get; set; }
        int NextRequestedFloorNumber { get; set; }
        List<int> AllRequestedFloorNumbers { get; set; }
        List<Rider> CurrentRiders { get; set; }

        void PickUpRiders(ICollection<Rider> riders);
        void DropOffRiders(ICollection<Rider> riders);
        void MoveToNextDestinationFloor();
        void MoveUpOneFloor();
        void MoveDownOneFloor();
    }
}
