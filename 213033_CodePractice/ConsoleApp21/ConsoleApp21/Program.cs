// Ali Shaan - 213033
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication8 
{ class a 
    { 
        public void display() 
        { 
            Console.WriteLine("hahahaha");
        } 
    } 
    class b : a //b is child of a
       { 
        public void display1() 
        { 
            Console.WriteLine("hihihih");
        }
    } 
    class d : b //d is child of b
       { 
        public void display2() 
        { 
            Console.WriteLine("hohohohoh");
        } 
    }
    class c 
    { 
        public static void Main() 
        {
            d x = new d();  //Normally object of child
            x.display();
            x.display1();
            x.display2(); 
        } 
    }
}