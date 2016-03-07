using System;
using System.Collections.Generic;

namespace Ex.Sixth.Struct
{
    class Depo
    {
        private SortedList<int, Train> depo = new SortedList<int, Train>();

        public void AddTrain()
        {
            try
            {
                Console.WriteLine("Create new train.");

                Console.WriteLine("Add train destination: ");
                string tmpToPoint = Console.ReadLine();

                Console.WriteLine("Add train departs in YYYY/MM/DD HH:MM");
                Console.Write("  ==> ");
                DateTime tmpTime = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Add number of train: ");
                int tmpNumber = Int32.Parse(Console.ReadLine());

                depo.Add(tmpNumber, new Train(tmpToPoint, tmpNumber, tmpTime));
                Console.WriteLine("Train N.{0} added.", tmpNumber);
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Invalid value, try again.");
                AddTrain();
            }
        }

        public void ShowTrain()
        {
            try
            {
                Console.WriteLine("Enter a train's number to view it: ");
                int tmpNumber = Int32.Parse(Console.ReadLine());

                if (depo.ContainsKey(tmpNumber))
                {
                    depo[tmpNumber].Show();
                }
                else Console.WriteLine("There are no trains with this numbers.");
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Invalid value, try again.");
                ShowTrain();
            }
        }
    }
}
