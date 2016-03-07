using System;
using System.Reflection;

namespace Ex.Sixth.Struct
{
    partial class Presenter
    {
        public void MainPrinter()
        {
            Console.WriteLine("Enter what u want to view:\n");
            string stroka = Console.ReadLine();
            Console.WriteLine("Now look at colors list and chose one:");

            foreach (var value in Enum.GetValues(typeof(Colors)))
            {
                Console.WriteLine("{0} -{1}", (int)value, ((Colors)value));
            }

            Console.Write("\nNow enter key of color: ");
            int colorNumber = 0;
            while (true)
            {
                if(int.TryParse(Console.ReadLine(), out colorNumber) && colorNumber >= 0 && colorNumber < 15)
                {
                    break;
                }
                Console.Write("Wrong value, try again: ");
            }

            Printer.Print(stroka, colorNumber);
        }
    }
}
