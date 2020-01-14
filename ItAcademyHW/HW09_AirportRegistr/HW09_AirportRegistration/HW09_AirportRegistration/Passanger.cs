using System;
using System.Collections.Generic;
using System.Text;

namespace HW09_AirportRegistration
{
    public class Passanger
    {
        
        public Citizenship citizenship { get; private set; }
        public Title title { get; private set; }
        public string firstName { get; private set; }
        public string secondName { get; private set; }
        public DateTime birthDate { get; private set; }
        public Passanger(string firstName, string secondName, DateTime birthDate,
                          Citizenship citizenship = Citizenship.Resident, 
                          Title title = Title.Mr)
        {
            this.citizenship = citizenship;
            this.title = title;
            this.firstName = firstName;
            this.secondName = secondName;
            this.birthDate = birthDate;
        }
    }
}
