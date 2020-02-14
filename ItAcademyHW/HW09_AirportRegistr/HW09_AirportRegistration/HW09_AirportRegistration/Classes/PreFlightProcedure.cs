using System;
using System.Collections.Generic;
using System.Text;

namespace HW09_AirportRegistration
{
    class PreFlightProcedure
    {
        private Passanger passanger;
        private bool checkInStatus;
        private Status _currentStatus
        {           
            set
            {
                if (value == Status.Warning)
                    CallThePoliceEvent(this);
                if (value == Status.Failed)
                    RagistrationFailEvent(this);
            }
        }

        private RegistrationStage _currentStage;
        public RegistrationStage CurrentStage
        {         
            get { return _currentStage; }
            set
            {
                _currentStage = value;
                if (value == RegistrationStage.CheckIn)
                    this.CheckInEvent(); 
                if (value == RegistrationStage.SecurityCheck)
                    this.SecurityCheckEvent();
                if (value == RegistrationStage.PassportControl)
                    this.PassportControlEvent();
            }
        }
        public PreFlightProcedure(Passanger passanger, bool checkInStatus = false )
        {
            this.passanger = passanger;
            this.checkInStatus = checkInStatus;
            CurrentStage = RegistrationStage.Beginning;
            _currentStatus = Status.Ok;
        }
        public void Start()
        {            
            
            while (CurrentStage != RegistrationStage.Finished)
            {
                switch (CurrentStage)
                {
                    case RegistrationStage.Beginning: Greeting();
                        break;
                    case RegistrationStage.CheckIn: CheckInProcedure();
                        break;
                    case RegistrationStage.SecurityCheck: SecurityCheckProcedure();
                        break;
                    case RegistrationStage.PassportControl: PassportControlProcedure();
                        break;
                    default:
                        break;
                }
            }
        }

        private void PassportControlProcedure()
        {
            if(passanger.citizenship == Citizenship.Resident)
            PassportDataControlResident();
            else
            PassportDataControlNonResident();
        }
        private void PassportDataControlNonResident()
        {
            string visaDateS;
            Console.WriteLine("Custom inspector: When your visa date expire ?");
            Console.WriteLine("Visa date(m/dd/yyyy): ");
            visaDateS = Console.ReadLine();
            DateTime visaDate = DateTime.Parse(visaDateS);
            
            if (visaDate < DateTime.Now)
            {
                Console.WriteLine("Custom inspector: Your visa is out of date. " +
                    "Police will be here in a second");
               _currentStatus = Status.Warning;
            }
            if(CurrentStage != RegistrationStage.Finished)
            PassportDataControlResident();
        }
        private void PassportDataControlResident()
        {
            string firstnameCheck;
            string secondnameCheck;

            Console.WriteLine($"Custom inspector: Please tell me your full name {passanger.title}");
            Console.WriteLine("First name: ");
            firstnameCheck = Console.ReadLine();
            Console.WriteLine("Second name: ");
            secondnameCheck = Console.ReadLine();
            Console.WriteLine($"Me: My name is {firstnameCheck} {secondnameCheck} ");
            if (firstnameCheck != passanger.firstName || secondnameCheck != passanger.secondName)
            {
                string controlQuestion;
                Console.WriteLine($"Custom inspector: Please tell me your date of " +
                    $"your birth {passanger.title}. {firstnameCheck} {secondnameCheck}");
                Console.WriteLine("Birth date(m/dd/yyyy): ");
                controlQuestion = Console.ReadLine();
                if (controlQuestion != passanger.birthDate.ToShortDateString())
                {
                    Console.WriteLine(passanger.birthDate.ToShortDateString());
                    _currentStatus = Status.Warning;
                }
                else
                {
                    Console.WriteLine($"Custom inspector: You can pass," +
                        $" {passanger.title}. {passanger.firstName} {passanger.secondName}");
                    HaveANiceFlightEvent(this);
                }
            }
            else
            {
                Console.WriteLine($"Custom inspector: You can pass," +
                         $" {passanger.title}. {passanger.firstName} {passanger.secondName}");
                HaveANiceFlightEvent(this);
            }
            
        }
        private void SecurityCheckProcedure()
        {
            UltraVioletLine();
            if(CurrentStage != RegistrationStage.Finished)
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
                Console.WriteLine("Me: Yes, I have.");
                Console.WriteLine("Security: In that case I'm going to call the police. ");
                _currentStatus = Status.Warning;
            }
            else
            {
                Console.WriteLine("Me: No.");
                Console.WriteLine("Security: Thank you, now you can follow to Passport control. ");
                CurrentStage = RegistrationStage.PassportControl;
            }
        }
        private void UltraVioletLine()
        {
            Console.WriteLine("Security: Please put your gadgets, bags, mettalic thing etc. on the line");
            string answ = string.Empty;
            while (answ != "put")
            {
                Console.WriteLine("(put - to put things on the line)");
                answ = Console.ReadLine();
            }
        }
        public void Stop()
        {
            CurrentStage = RegistrationStage.Finished;
        }
        private void CheckInProcedure()
        {
            PassportCheck();
            if(CurrentStage != RegistrationStage.Finished)
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
                _currentStatus = Status.Failed;
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
                    _currentStatus = Status.Failed;
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
        public event Action PassportControlEvent;

    }
}
