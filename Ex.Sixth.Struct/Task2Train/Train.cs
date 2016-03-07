using System;

namespace Ex.Sixth.Struct
{
    struct Train
    {
        private string toPoint;
        private int number;
        private DateTime time;

        public Train(string toPoint, int number, DateTime time)
        {
            this.toPoint = toPoint;
            this.number = number;
            this.time = time;
        }

        public void Show()
        {
            Console.WriteLine("\nTrain number:{0}", number);
            Console.WriteLine("Coming to {0}", toPoint);
            Console.WriteLine("the train departs at {0}\n", time);
        }
    }
}
