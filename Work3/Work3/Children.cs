using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work3
{
    abstract class Children : IDefineClass
    {
        public static string name;
        public static int age;
        public abstract void Define();
    }
}
