using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03.Interface01
{
    internal interface IMyType
    {
        //What can we write inside interface?
        // 1. Signature Of Property
        void MyFun();

        // 2. Signature Of Methods [Name, Parameter, Return Type]
        double Salary { set; get; }

        // 3. Default implemented methods [Fully Implemented Methods]
        void Print()
        {
            Console.WriteLine("Default implemented methods [Fully Implemented Methods]");
        }
    }
}
