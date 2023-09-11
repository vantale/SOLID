using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.CodeSmells.FeatureEnvy
{
    internal class TVSet
    {
        public void TurnOn() { }
        public void TurnOff() { }

        public bool CheckIsOn() { return true; }
        public void SwitchChannel(int number) { }
    }
}
