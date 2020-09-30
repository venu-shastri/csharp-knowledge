using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tally
{
    class Program
    {
        static void Main(string[] args)
        {
            RiskCalculatorLib.RiskCalculator obj = new RiskCalculatorLib.RiskCalculator();
            obj.Calculate();
        }
    }
}
