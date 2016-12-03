using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElevatorLP.Core;
using System.Collections;

namespace ElevatorLogicProblemConsole
{
    class Program
    {
        private static void StartElevatorInfo()
        {
            Elevator otis1 = new Elevator("Otis 1", 0, 0, 0, null, null);
            Elevator otis2 = new Elevator("Otis 2", 0, 0, 0, null, null);
        }

        Rider steve = new Rider(001, 0, 0, 0, 0);

        static void Main(string[] args)
        {            
            StartElevatorInfo();
        }        
    }
}
