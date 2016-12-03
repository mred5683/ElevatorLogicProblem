using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElevatorLP.Core.Interfaces;

namespace ElevatorLP.Core
{
    public class Building : IBuilding
    {
        public bool IsOpen { get; set; }
        public int MaxCapacity { get; }
        public int CurrentCapacity { get; set; }
        public ICollection<Elevator> Elevators { get; }

        public Building(ICollection<Elevator> elevators)
        {
            Elevators = elevators;
            MaxCapacity = Convert.ToInt32(ConfigurationManager.AppSettings["100"]);
            CurrentCapacity = 0;
            IsOpen = false;
        }

        public void APersonArrived()
        {
            CurrentCapacity += 1;
        }

        public void APersonDeparted()
        {
            CurrentCapacity -= 1;
        }

        public void OpenDoors()
        {
            IsOpen = true;
        }

        public void CloseDoors()
        {
            IsOpen = false;
        }
    }
}
