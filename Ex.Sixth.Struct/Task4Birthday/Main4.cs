using NUnit.Framework;
using System;

namespace Ex.Sixth.Struct
{
    partial class Presenter
    {
        public void Birthday()
        {
            BirthdayCalculator calculator = new BirthdayCalculator();
            try
            {
                Console.WriteLine("Enter your birthday YYYY/MM/DD: ");
                Console.Write("  ==> ");
                DateTime birthday = DateTime.Parse(Console.ReadLine());
                calculator.Calculate(birthday);
                calculator.ShowDays();
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Invalid value, try again.");
                Birthday();
            }

        }

        [Test]
        public void TestB()
        {
            BirthdayCalculator calculator = new BirthdayCalculator();
            Assert.AreEqual(75, calculator.Calculate(new DateTime(1996, 5, 21)));
            Assert.AreEqual(14, calculator.Calculate(new DateTime(1996, 3, 21)));
        }
    }
}
