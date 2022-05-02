using System;
namespace tribeca
{
    public static class StarSign
    {

        public enum StarSigns
        {
            Aries,
            Taurus,
            Gemini,
            Cancer,
            Leo,
            Virgo,
            Libra,
            Scorpio,
            Sagittarius,
            Capricorn,
            Aquarius,
            Pisces
        }

        public static string GetStarSign(this Person person)
        {
            var dob = person.DateOfBirth;

            if ((dob.Day >= 21 && dob.Month == 3) || (dob.Day <= 20 && dob.Month == 4))
                return StarSigns.Aries.ToString();
            else if ((dob.Day >= 21 && dob.Month == 4) || (dob.Day <= 20 && dob.Month == 5))
                return StarSigns.Taurus.ToString();
            else if ((dob.Day >= 21 && dob.Month == 5) || (dob.Day <= 20 && dob.Month == 6))
                return StarSigns.Gemini.ToString();
            else if ((dob.Day >= 21 && dob.Month == 6) || (dob.Day <= 20 && dob.Month == 7))
                return StarSigns.Cancer.ToString();
            else if ((dob.Day >= 21 && dob.Month == 7) || (dob.Day <= 20 && dob.Month == 8))
                return StarSigns.Leo.ToString();
            else if ((dob.Day >= 21 && dob.Month == 8) || (dob.Day <= 20 && dob.Month == 9))
                return StarSigns.Virgo.ToString();
            else if ((dob.Day >= 21 && dob.Month == 9) || (dob.Day <= 20 && dob.Month == 10))
                return StarSigns.Libra.ToString();
            else if ((dob.Day >= 21 && dob.Month == 10) || (dob.Day <= 20 && dob.Month == 11))
                return StarSigns.Scorpio.ToString();
            else if ((dob.Day >= 21 && dob.Month == 11) || (dob.Day <= 20 && dob.Month == 12))
                return StarSigns.Sagittarius.ToString();
            else if ((dob.Day >= 21 && dob.Month == 12) || (dob.Day <= 20 && dob.Month == 1))
                return StarSigns.Capricorn.ToString();
            else if ((dob.Day >= 21 && dob.Month == 1) || (dob.Day <= 20 && dob.Month == 2))
                return StarSigns.Aquarius.ToString();
            else
                return StarSigns.Pisces.ToString();
        }

    }
}

