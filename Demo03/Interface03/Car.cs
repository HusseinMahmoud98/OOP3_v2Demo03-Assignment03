using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03.Interface03
{
    internal class Car : IMovable
    {
        int IMovable.Speed { get; set; }

        public void Backward()
        {
            Console.WriteLine("Car IMovable Backword");
        }

        public void Forward()
        {
            Console.WriteLine("Car IMovable Forward");
        }

        public void Left()
        {
            Console.WriteLine("Car IMovable Left");
        }

        public void Right()
        {
            Console.WriteLine("Car IMovable Right");
        }
    }
}
