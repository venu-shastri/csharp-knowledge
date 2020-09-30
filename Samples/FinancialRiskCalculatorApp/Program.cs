using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialRiskCalculatorApp
{

    class Program
    {
        static void Main(string[] args)
        {

            //Early Binding
            //Safe - Compiler verify type info
            //Compiler Reflects RiskCalculatorLib Metadata
            RiskCalculatorLib.RiskCalculator obj = new RiskCalculatorLib.RiskCalculator();
            obj.Calculate();
           
        }
    }
}
