using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03.Q01
{
    internal class Rectangle : IRectangle
    {
        public double Area { get; set; }
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Shape is Rectangle with Area = {Area}");
        }
    }
}
