using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_7_Task_1_Calculator
{
    class Calculate : BasicCalculator, ScientificCalculator
    {
        
        public int add(int x, int y)
        {
            int r = x + y;
            Console.WriteLine("Sum of  "+ x + " and "+ y +" is "+ r);
            return r;
        }

        public int division(int x, int y)
        {
            int r = x / y;
            Console.WriteLine("Division of  " + x + " and " + y + "is " + r);
            return r;

        }

        public double log(double x)
        {
            double r = (double)Math.Log(x);
            Console.WriteLine("log of  " + x + " is " + r);
            return r;
        }

        public int multiplication(int x, int y)
        {
            int r = x * y;
            Console.WriteLine("Multiplication of  " + x + " and " + y + " is " + r);
            return r;
        }

        public int subtract(int x, int y)
        {
            int r = x - y;
            Console.WriteLine("subtract of " + x + " and " + y + " is " + r);
            return r;
        }

        public int XtoY(int x, int y)
        {
            int r = (int)Math.Pow(x, y);
            Console.WriteLine("Power of  " + x + " and " + y + "is " + r);
            return r;
        }
    }
}
