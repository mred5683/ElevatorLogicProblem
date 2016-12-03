using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElevatorLP.Core.Interfaces;

namespace ElevatorLP.Core
{
    public class Elevator : IElevator
    {
        public string ElevatorId { get; set; }
        public int NumberOfRiders { get; set; }
        public int CurrentFloorNumber { get; set; }
        public int NextRequestedFloorNumber { get; set; }
        public List<int> AllRequestedFloorNumbers { get; set; }
        public List<Rider> CurrentRiders { get; set; }

        public Elevator(string elevatorId, int numberOfRiders, int currentFloorNumber, int nextRequestedFloorNumber, 
                                List<int> allRequestedFloorNumbers, List<Rider> currentRiders)
        {
            ElevatorId = elevatorId;
            NumberOfRiders = numberOfRiders;
            CurrentFloorNumber = currentFloorNumber;
            NextRequestedFloorNumber = nextRequestedFloorNumber;
            AllRequestedFloorNumbers = allRequestedFloorNumbers;
            CurrentRiders = currentRiders;
        }

        public void PickUpRiders(ICollection<Rider> riders)
        {
            foreach (var rider in riders)
            {
                AllRequestedFloorNumbers.Add(rider.SelectFloor());
            }
        }

        public void DropOffRiders(ICollection<Rider> riders)
        {
            throw new NotImplementedException();
        }

        public void MoveToNextDestinationFloor()
        {
            if(CurrentFloorNumber == NextRequestedFloorNumber)
            {

            }
            throw new NotImplementedException();
        }

        public void MoveUpOneFloor()
        {
            CurrentFloorNumber += 1;
        }

        public void MoveDownOneFloor()
        {
            CurrentFloorNumber -= 1;
        }
    }
}
