using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03.Interface01
{
    internal class MyType : IMyType
    {
        public double Salary { get; set; }

        public void MyFun()
        {
            Console.WriteLine("Hello from Fun");
        }
    }
}
