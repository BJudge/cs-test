using System;
namespace tribeca
{
    public class Person
    {
        private string _name;
        private string _surname;
        private DateTime _dateofbrith;

        public string Name
        {
            get
            { return _name; }
            set
            { _name = value; }
        }

        public string Surname
        {
            get
            { return _surname; }
            set
            { _surname = value; }
        }

        public DateTime DateOfBirth
        {
            get
            { return _dateofbrith; }
            set
            {
                if (CalculateAge(value) > 150 || CalculateAge(value) < 0) { throw new ArgumentException("Date Of Birth Invalid"); }
                _dateofbrith = value;
            }
        }

        public int Age
        {
            get
            { return CalculateAge(DateOfBirth); }
        }

        public int CalculateAge(DateTime dob)
        {
            var todaysDate = DateTime.Today;
            var diff = todaysDate - dob;
            return (int)(diff.TotalDays / 365);
        }


    }
}
