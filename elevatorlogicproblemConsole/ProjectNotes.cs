using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorLogicProblemConsole
{
    class ProjectNotes
    {
        //Author: Mark Feldman
        //Purpose: This exercise will be logical routine building and modulation for expansion skill building - efficiency matters

        //Background: This is a real world issue that most people take for granted.

        //Scenario:     There is a 100 story building which has 2 elevators. (floors 0 - 99) 
        //              The building holds up to 100 people
        //              Each elevator holds a maximum of 10 riders

        //TODO LATER    It takes 1 second to traverse each floor (ex from floor 0 to floor 9 takes 9 seconds)

        //TODO LATER    It takes 1 second to drop off or pick up 1 rider (multiple riders may get on an elevator at a single floor, 10 riders would 
        //TODO LATER        take 10 seconds to load or unload)
 
        //              Riders are responsible for knowing what floor they are on and what floor they want to visit 
 
        //              Riders are responsible for knowing what time they are wanting to arrive and leave the building, along with what time
        //                  what time they will want to traverse to other floors

        //                  Riders in this example will only arrive, traverse floors, and leave (no multiple floor traversing trips in a day)

        //                  Riders will signal the elevators to request pick up

        //                  Elevators need to communicate to riders what direction they are heading (Riders will evaluate which elevator to use)

        //Exercise: Build the algorithym both elevators use to determine the following: 

        //              - On what floor should each elevator wait when there is no one wanting to ride and the building is empty? (The only floor
        //                  to get into the building is floor 0)

        //              - Which elevator should pick up a rider at a particular floor? (heading up or down matters)
 
        //              - What does an elevator do if it is full and there is a rider waiting to get on?

        //              - Where should each elevator wait when there is no one wanting to ride, but the building is full? (having no knowledge of 
        //                  what floors the riders are on)

        //TODO LATER    -Scope: The building will open at 8:00 am and close at 6:00 pm 

        //TODO LATER            There will be 10 riders waiting in the lobby (floor 0) at 8:00 am, and 10 riders will arrive every minute after. 
        //TODO LATER                (building max is 100)

        //TODO LATER            At 5:00 pm riders will start to leave the building as they are now off work. 10 riders will want to leave every 10 minutes
        //                          until 5:30, when ALL riders will want to leave; 
        //                          all riders must be out of the building by 6:00 pm
    }
}
