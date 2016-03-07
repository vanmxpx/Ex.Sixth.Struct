using System;

namespace Ex.Sixth.Struct
{
    partial class Presenter
    {
        public void Train()
        {
            Depo mainDepo = new Depo();
            for (int i = 0; i < 8; i++)
            {
                mainDepo.AddTrain();
                Console.WriteLine();
            }

            bool flag = true;
            while (flag)
            {
                Console.Clear();

                mainDepo.ShowTrain();
                Console.WriteLine("\nEnter 'a' to repiet.");
                Console.WriteLine("Enter any key to exit.");
                if (Console.ReadLine() != "a") flag = false;
            }
        }
    }
}
