﻿// Ali Shaan - 213033
using System;
delegate void mdelegate();
namespace DelegateApp1 {
    class dm 
    { 
        static public void display() 
        {
            Console.WriteLine("New Delhi");
        } 
        static public void print() 
        {
            Console.WriteLine("New York");
        } 
    } 
    class mtest { 
        public static void Main() 
        {
            mdelegate m1 = new mdelegate(dm.display);
            mdelegate m2 = new mdelegate(dm.print);
            mdelegate m3 = m1 + m2;
            mdelegate m4 = m2 + m1;
            mdelegate m5 = m3 - m2;
            m3(); 
            m4(); 
            m5(); 
        }
    } 
}