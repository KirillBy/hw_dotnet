using System;
using System.Collections.Generic;
using System.Text;

namespace HW09_AirportRegistration
{
    class PreFlightProcedure
    {
        private Passanger passanger;
        private bool checkInStatus;
        private Status currentStatus
        {
            
            set
            {
                if (value == Status.Warning)
                    CallThePoliceEvent(this);
                if (value == Status.Failed)
                    RagistrationFailEvent(this);
            }
        }
        private RegistrationStage currentStage;
        public RegistrationStage CurrentStage
        {         
            get { return currentStage; }
            set
            {
                currentStage = value;
                if (value == RegistrationStage.Finished)
                    this.HaveANiceFlightEvent(this);
                if (value == RegistrationStage.CheckIn)
                    this.CheckInEvent(); 
                if (value == RegistrationStage.SecurityCheck)
                    this.SecurityCheckEvent();
            }
        }


        public PreFlightProcedure(Passanger passanger, bool checkInStatus = false )
        {
            this.passanger = passanger;
            this.checkInStatus = checkInStatus;
            currentStage = RegistrationStage.Beginning;
            currentStatus = Status.Ok;
        }
        public void Start()
        {            
            
            while (currentStage != RegistrationStage.Finished)
            {
                switch (currentStage)
                {
                    case RegistrationStage.Beginning: Greeting();
                        break;
                    case RegistrationStage.CheckIn: CheckInProcedure();
                        break;
                    case RegistrationStage.SecurityCheck: SecurityCheckProcedure();
                        break;
                    case RegistrationStage.PassportControl:
                        break;
                    default:
                        break;
                }
            }
        }

        private void SecurityCheckProcedure()
        {
            UltraVioletLine();
            if(currentStage != RegistrationStage.Finished)
            IllegalStaffCheck();
        }

        private void IllegalStaffCheck()
        {
            Console.WriteLine("Security: Thank you. Do you have any forbidden thing's ?");
            string answ = string.Empty;
            while (answ != "yes" && answ != "no")
            {
                Console.WriteLine("(yes/no)");
                answ = Console.ReadLine();
            }
            if (answ == "yes")
            {
                Console.WriteLine("Me: Yes, I have");
                Console.WriteLine("Security: In that case I'm going to call the police ");
                currentStatus = Status.Warning;
            }
            else
            {
                Console.WriteLine("Me: Of course - No.");
                Console.WriteLine("Security: Thank you, now you can follow to Passport control ");
                currentStage = RegistrationStage.PassportControl;
            }
        }

        private void UltraVioletLine()
        {
            Console.WriteLine("Security: Please put your gadgets, bags, mettalic thing etc. on the line");
            string answ = string.Empty;
            while (answ != "put")
            {
                Console.WriteLine("(put to put things on the line)");
                answ = Console.ReadLine();
            }
        }

        public void Stop()
        {
            currentStage = RegistrationStage.Finished;
        }
        private void CheckInProcedure()
        {
            PassportCheck();
            if(currentStage != RegistrationStage.Finished)
            LuggageControl();
        }
        private void PassportCheck()
        {
            Console.WriteLine("Registrator: Pass your passport, please.");

            string answ = string.Empty;
            while (answ != "give" && answ != "no")
            {
                Console.WriteLine("(give - to give passport, no - to regret)");
                answ = Console.ReadLine();
            }
            if (answ == "no")
            {
                Console.WriteLine("Me: Oh, I've lost my passport(((");
                currentStatus = Status.Failed;
            }
            else
                Console.WriteLine("Registrator: Thank you, here is your ticket.");
        }
        private void LuggageControl()
        {
            if (passanger.luggage > 20)
            {
                Console.WriteLine("Registrator: Your luggage is overweight. Please pay extra money");
                string answ = string.Empty;
                while (answ != "pay" && answ != "no")
                {
                    Console.WriteLine("(pay - to pay for the luggage, no - to regret)");
                    answ = Console.ReadLine();
                }
                if (answ == "no")
                {
                    Console.WriteLine("Me: Oh, I don't have enought money");
                    currentStatus = Status.Failed;
                }
                else
                {
                    Console.WriteLine("Registrator: Thank you. Now you can follow to " +
                        "the security check");
                    CurrentStage = RegistrationStage.SecurityCheck;
                }
            }
            else
            {
                Console.WriteLine("Registrator: Your luggage is normal weight." +
                 " Please follow to the security check");
                CurrentStage = RegistrationStage.SecurityCheck;
            }
             
        }
        private void Greeting()
        {
            Console.WriteLine($"Welcome to National Minsk Airport, {passanger.title}. " +
                $"{passanger.firstName} {passanger.secondName}");
            Console.WriteLine($"It's {DateTime.Now} now");
            if (!checkInStatus)
                CurrentStage = RegistrationStage.CheckIn;
            else
                CurrentStage = RegistrationStage.SecurityCheck;
        }

        public event Action<PreFlightProcedure> CallThePoliceEvent;
        public event Action<PreFlightProcedure> RagistrationFailEvent;
        public event Action<PreFlightProcedure> HaveANiceFlightEvent;
        public event Action CheckInEvent;
        public event Action SecurityCheckEvent;

    }
}
