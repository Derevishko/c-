using System;
using System.Collections.Generic;
using System.Text;

namespace Extends.classes
{
    class OverrideVirtualMethod : VirtualClass
    {
        public override void Print() { Console.WriteLine("OverrideVirtualMethod"); }
        public new void Print2() { Console.WriteLine("OverrideVirtualMethod"); }
    }
}
