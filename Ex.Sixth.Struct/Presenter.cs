using System;

namespace Ex.Sixth.Struct
{
    partial class Presenter
    {
        public void Run()
        {
            for(int i = 0; i < 6; i++)
            {
                switch (i)
                {
                    case 0:
                        Notebook();
                        break;
                    case 1:
                        Train();
                        break;
                    case 2:
                        Difference();
                        break;
                    case 3:
                        Birthday();
                        break;
                    case 4:
                        MainPrinter();
                        break;
                    case 5:
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Enter any key to continue");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
