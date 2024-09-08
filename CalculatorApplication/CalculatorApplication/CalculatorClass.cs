using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    public delegate T Computation<T>(T txtBoxInput1, T txtBoxInput2);
    internal class CalculatorClass
    {

        public Computation <double> info;
        

        public  double getSum(double txtBoxInput1, double txtBoxInput2)
        {
            return txtBoxInput1 + txtBoxInput2;
        }
        public double getDifference(double txtBoxInput1, double txtBoxInput2)
        {
            return txtBoxInput1 - txtBoxInput2;
        }
        public double getQuotient(double txtBoxInput1, double txtBoxInput2)
        {
            return txtBoxInput1 / txtBoxInput2;
        }
        public double getProduct(double txtBoxInput1, double txtBoxInput2)
        {
            return txtBoxInput1 * txtBoxInput2;
        }

       
        public event Computation<double> CalculateEvent
        {
            add
            {
                Console.WriteLine("Success, Delegate have been recieve");
            }
            remove
            {
                Console.WriteLine("Success, Delegate have been remove");
            }
        }
    }
}
