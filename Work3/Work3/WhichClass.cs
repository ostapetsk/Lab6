using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work3
{
    class WhichClass : Children
    {
        public WhichClass()
        {
            Define();
        }
        public override void Define()
        {
            if (age == 6)
            {
                Console.Write(name);
                IDefineClass.first();
            }
            if (age == 7)
            {
                Console.Write(name);
                IDefineClass.second();
            }
            if (age == 8)
            {
                Console.Write(name);
                IDefineClass.third();
            }
            if (age == 9)
            {
                Console.Write(name);
                IDefineClass.fourth();
            }
            if (age == 10)
            {
                Console.Write(name);
                IDefineClass.fifth();
            }
            if (age == 11)
            {
                Console.Write(name);
                IDefineClass.six();
            }
            if (age == 12)
            {
                Console.Write(name);
                IDefineClass.seventh();
            }
            if (age == 13)
            {
                Console.Write(name);
                IDefineClass.eight();
            }
            if (age == 14)
            {
                Console.Write(name);
                IDefineClass.nineth();
            }
            if (age == 15)
            {
                Console.Write(name);
                IDefineClass.ten();
            }
            if (age == 16)
            {
                Console.Write(name);
                IDefineClass.eleven();
            }
            else if (age >= 17)
            {
                Console.Write(name);
                Console.Write(" Доросла особа");
            }
        }
    }
}
