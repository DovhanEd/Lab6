using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcInterfaces;

namespace CalcServer
{
    class CalcService : ICalcService
    {
       public int Sum(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
