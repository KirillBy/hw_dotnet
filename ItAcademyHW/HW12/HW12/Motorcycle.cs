using System;
using System.Collections.Generic;
using System.Text;
namespace HW12
{
    public class Motorcycle
    {
        public  uint  Id { get; }
        public MotoNames Name { get; }
        public string Model { get; }
        public uint Year { get; }

        private uint _odometr;
        public uint Odometr
        {
            get { return _odometr; }
            set 
            { 
                if (value >= _odometr)
                    _odometr = value;
            }
        }

        public Motorcycle(uint Id, MotoNames Name, string Model, uint Year, uint Odometr = 0)
        {
            this.Id = Id;
            this.Name = Name;
            this.Model = Model;
            this.Year = Year;
            if (Year < 1940 || Year > int.Parse(DateTime.Now.Year.ToString()))
                throw new ArgumentOutOfRangeException("Incorrect year");
            this._odometr = Odometr;
        }
    }
}
