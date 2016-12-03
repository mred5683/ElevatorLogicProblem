using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorLP.Core.Interfaces
{
    public interface IBuilding
    {
        /// <summary>
        /// Status of the building being open or not
        /// </summary>
        bool IsOpen { get; set; }
        /// <summary>
        /// The maximum number of people allowed in the building
        /// </summary>
        int MaxCapacity { get; }
        /// <summary>
        /// The current number of people in the building
        /// </summary>
        int CurrentCapacity { get; set; }
        /// <summary>
        /// The elevators the building has
        /// </summary>
        ICollection<Elevator> Elevators { get; }
        /// <summary>
        /// The building opens at 8:00 am
        /// </summary>
        void OpenDoors();
        /// <summary>
        /// The building closes at 6:00 pm
        /// </summary>
        void CloseDoors();
        /// <summary>
        /// A person has entered the building
        /// </summary>
        void APersonArrived();
        /// <summary>
        /// A person has left the building
        /// </summary>
        void APersonDeparted();
    }
}
