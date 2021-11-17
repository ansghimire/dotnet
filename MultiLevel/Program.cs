using System;

namespace MultiLevel
{



    class A {
        public int a,b,c;

        public void setData(int a, int b){
            this.a = a;
            this.b = b;
        }
        public void display(){
            Console.WriteLine("Value of a and b is "+a, +b);

        }
    }

    class B : A {
        public void Add(){
            base.c = base.a + base.b;
            Console.WriteLine("Sum of a and b is "+ base.c);
        }
    }

    class C : B {
        public void Sub(){
            base.c = base.a - base.b;
            Console.WriteLine("Difference of a and b is "+ base.c);
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
           C ob = new C();
           ob.setData(30,50);
           ob.display();
           ob.Add();
           ob.Sub();
        }
    }
}
