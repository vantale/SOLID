using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.CodeSmells.RefusedBequest
{
    internal class ClassA
    {
        public Door[] Doors { get; set; }
        public Window[] Windows { get; set; }
        public Roof Roof { get; set; }
        public Floor[] Floors { get; set; }
        public Seat[] Seats { get; set; }

        public void RingBell() { }
        public void MownLawn() { }
        public void WaterPlants() {  }
        public void WashDishes() { }
        public void LetDogsOut() { }
        public void TrapBurglarsInBasement() { }
    }
}
