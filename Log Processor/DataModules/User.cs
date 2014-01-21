using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Log_Processor
{
    public class User
    {
        public int ID;
        public string name;
        public Options.Gender gender;
        public Options.Laterality laterality;
        public int yearOfBirth;

        public User(int _ID, string _name, Options.Gender _gender, Options.Laterality _laterality, int _yearOfBirth)
        {
            this.ID = _ID;
            this.name = _name;
            this.gender = _gender;
            this.laterality = _laterality;
            this.yearOfBirth = _yearOfBirth;
        }
    }

}
