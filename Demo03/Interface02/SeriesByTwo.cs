using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03.Interface02
{
    internal class SeriesByTwo : ISeries
    {
        public int Current { get; set; }

        public void Next()
        {
            Current += 2;
        }
    }
}
