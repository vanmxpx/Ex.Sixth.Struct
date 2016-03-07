using System;

namespace Ex.Sixth.Struct
{
    public enum Colors
    {
        Black,
        DarkBlue,
        DarkGreen,
        DarkCyan,
        DarkRed,
        DarkMagenta,
        DarkYellow,
        Gray,
        DarkGray,
        Blue,
        Green,
        Cyan,
        Red,
        Magenta,
        Yellow,
        White

    }
    public static class Printer
    {
        public static void Print(string stroka, int color)
        {
            Console.Clear();
            Console.ForegroundColor = (ConsoleColor)color;
            Console.WriteLine(stroka);
            Console.ResetColor();
        }
    }
}
