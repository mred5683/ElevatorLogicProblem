using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ElevatorLP.Core.Interfaces;

namespace ElevatorLP.Core
{
    public class Rider : IRider
    {
        public int RiderId { get; set; }
        public int[] FloorVisitingPlan { get; set; }
        public int CurrentFloor { get; set; }
        public int HourOfArrival { get; set; }
        public int HourOfDeparture { get; set; }
        public int HourOfFloorTraverse { get; set; }
        public Building Building { get; }

        public Rider(int riderId, int currentFloor, int hourOfArrival, int hourOfDeparture, int hourOfFloorTraverse)
        {
            RiderId = riderId;
            currentFloor = CurrentFloor;
            HourOfArrival = hourOfArrival;
            HourOfDeparture = hourOfDeparture;
            HourOfFloorTraverse = hourOfFloorTraverse;
        }


        public Rider(Building building)
        {
            Building = building;
        }

        public void SignalElevator(ElevatorDirection upOrDown)
        {
            throw new NotImplementedException();
        }

        public int SelectFloor()
        {
            throw new NotImplementedException();
        }

        public void ArriveToWork()
        {
            CurrentFloor = 0;
            Building.APersonArrived();
            SignalElevator(ElevatorDirection.Up);
        }

        public void DepartFromWork()
        {
            throw new NotImplementedException();
        }

        public void SetFloorVisitPath()
        {
            throw new NotImplementedException();
        }
    }
}
