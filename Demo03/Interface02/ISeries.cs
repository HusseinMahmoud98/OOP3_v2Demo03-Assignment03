using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03.Interface02
{
    internal interface ISeries
    {
        int Current { get; set; } //Signature Of Property

        void Next();
        public void Reset()
        {
            Current = 0;
        }
    }
}
