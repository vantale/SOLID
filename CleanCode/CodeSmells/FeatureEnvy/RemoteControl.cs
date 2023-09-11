using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.CodeSmells.FeatureEnvy
{
    internal class RemoteControl
    {
        private TVSet TVSet { get; }

        public RemoteControl(TVSet tvSet)
        {
            TVSet = tvSet;
        }
        public void TurnOn() { TVSet.TurnOn(); }
        public void TurnOff() { TVSet.TurnOff(); }

        public bool CheckIsOn() { return TVSet.CheckIsOn(); }
        public void SwitchChannel(int number) { TVSet.SwitchChannel(number); }

        public int BatteryLevel => 99; 
    }
}
