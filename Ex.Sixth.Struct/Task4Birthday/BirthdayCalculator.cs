using System;

namespace Ex.Sixth.Struct
{
    class BirthdayCalculator
    {
        private double daysLeft;

        public double Calculate(DateTime birthday)
        {
            
            
            DateTime tmp = new DateTime(DateTime.Today.Year, birthday.Month, birthday.Day);
            if (tmp.Subtract(DateTime.Today).TotalDays < 0)
            {
                 tmp = tmp.AddYears(1);
            }
            TimeSpan left = tmp.Subtract(DateTime.Today);
            daysLeft = left.TotalDays;
            return daysLeft;
        }

        public void ShowDays()
        {
            Console.WriteLine("Days to birthday: {0} ", daysLeft);
        }
    }
}
