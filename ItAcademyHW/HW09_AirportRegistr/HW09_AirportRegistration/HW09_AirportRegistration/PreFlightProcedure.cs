using System;
using System.Collections.Generic;
using System.Text;

namespace HW09_AirportRegistration
{
    class PreFlightProcedure
    {
        private Passanger passanger;
        private bool checkInStatus;
        private RegistrationStage currentStage {  set 
                                                    { if (value == RegistrationStage.Failed)
                                                          CallThePoliceEvent();
                                                    } 
                                               }
        public PreFlightProcedure(Passanger passanger, bool checkInStatus = false )
        {
            this.passanger = passanger;
            this.checkInStatus = checkInStatus; 
        }
        public void Start()
        {
            Greeting();
            if (!checkInStatus)
                    CheckInProcedure();

        }

        private void CheckInProcedure()
        {
            currentStage = RegistrationStage.CheckIn;
            Console.WriteLine("Registrator: Check-in first, please."); 
            Console.WriteLine("Registrator: Pass your passport, please.");
           
            string answ = string.Empty;
            while(answ != "give" && answ != "no")
            { 
                Console.WriteLine("give - to give passport, no - to regret");
                answ = Console.ReadLine();
            }
            currentStage = answ == "give" ? RegistrationStage.SecurityCheck : RegistrationStage.Failed;
        }

        private void Greeting()
        {
            Console.WriteLine($"Welcome to National Minsk Airport, {passanger.title}. " +
                $"{passanger.firstName} {passanger.secondName}");
            Console.WriteLine($"It's {DateTime.Now} now");
            Console.WriteLine("***********************************************************************************\n\n\n");
        }

        public event Action CallThePoliceEvent;
           
    }
}
