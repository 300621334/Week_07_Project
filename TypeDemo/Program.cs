using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            //C c = new C(); // won't compile. can't instantiate abstract class.
            C c = new P(); // child of static class can be obj.
            D d = new D();
            //E e = new E(); // cannot inst static class. just use it as is.
            //IG ig = new IG(); // cant inst iface bu can do following
            IG ig = new Q();
        }
    }
}
