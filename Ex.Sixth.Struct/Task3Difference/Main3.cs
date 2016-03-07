using System;

namespace Ex.Sixth.Struct
{
    partial class Presenter
    { 
        public void Difference()
        {
            MyClass firstClass = new MyClass();
            MyStruct firstStruct = new MyStruct();

            firstClass.change = "Don't changed.";
            firstStruct.change = "Don't changed.";

            ClassTaker(firstClass);
            StructTaker(firstStruct);
            Console.WriteLine(firstClass.change);
            Console.WriteLine(firstStruct.change);
            /// <summary>
            /// Struct Taker takes only instance where the structure is value and method changes only instance
            /// </summary>

        }

        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "changed";
        }

        static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "changed";
        }
    }
}
