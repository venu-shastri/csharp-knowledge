using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateInternals
{
    public delegate int PerformCalculation(int x, int y);
    public class Calculator
    {

        public int Add(int x, int y)
        {
            return x + y;
        }
        public double Add(double x, double y)
        {
            return x + y;

        }

        public int Sub(int x,int y)
        {
            return x - y;
        }
        public double Mul(double x, double y)
        {
            return x * y;
        }
    }

    public class Computer
    {

        public void  Compute(PerformCalculation obj)
        {

           int result= obj.Invoke(10,20);
            Console.WriteLine(result);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator _calcObj = new Calculator();
            PerformCalculation _funObject = new PerformCalculation(_calcObj.Add);
            Computer _comp = new Computer();
            _comp.Compute(_funObject);

            PerformCalculation _newFunObject = new PerformCalculation(_calcObj.Sub);
            _comp.Compute(_newFunObject);

        }
    }
}
