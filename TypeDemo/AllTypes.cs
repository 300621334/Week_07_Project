using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeDemo
{
    class A
    {
        public int age; public void Foo() { }
        //public void Bar(); //won't work unless declare "partial" i.e completed in another class. //partial class A {}
        //or mark it abstract (if no body)
    }
    struct B //: A //struct only inherit from obj. not from class
    {
        public int age; public void Foo() { }
    }
    abstract class C //cannot "new". Meant to be parent of some other classes.
    {
        public int age; public void Foo() { }
        public abstract void bar(); // to be completed in child "P"
    }
    sealed class D
    {
        public int age; public void Foo() { }
    }
    static class E
    {
        public static int age; public static void Foo() { } // all ele be static
    }
    interface IG
    {
        //public int age;//won't work
        //ONLY method declarations go in iface
        void Buz(); //omit {} in iface
    }

    class P : C 
    {
        public override void bar(){} //completes work of abstract parent
    }
    class Q : IG
    {
        public void Buz() { }
    }
        //class R : D  //cannot be a child of a sealed class. Cant inherit
        //{}
        

        //class S : B //struct is a sealed type. so cannot be parent
        //{ }
    
}
