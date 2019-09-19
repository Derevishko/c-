using System;
using Extends.classes;

namespace Extends
{
    class Program
    {
        static void Main(string[] args)
        {
            // перезапись

            Console.WriteLine("override Print1");
            OverrideVirtualMethod cl1 = new OverrideVirtualMethod();
            VirtualClass cl2 = new OverrideVirtualMethod();
            VirtualClass cl3 = new VirtualClass();
            OverrideVirtualMethod cl4 = new OverrideVirtualMethod();

            cl1.Print(); // OverrideVirtualMethod
            cl2.Print(); // OverrideVirtualMethod
            cl3.Print(); // VirtualClass
            ((VirtualClass)cl3).Print(); // VirtualClass

            // Сокрытие
            Console.WriteLine("\nnew Print2");
            cl1.Print2(); // OverrideVirtualMethod
            cl2.Print2(); // VirtualClass
            cl3.Print2(); // VirtualClass
            ((VirtualClass)cl3).Print2(); // VirtualClass

        }
    }
}
