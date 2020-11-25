using System;

namespace LAB_7_Task_1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate c = new Calculate();
            c.add(2, 3);
            c.subtract(10, 5);
            c.multiplication(5, 2);
            c.division(20, 4);
            c.log(2);
            c.XtoY(2, 3);
        }
    }
}
