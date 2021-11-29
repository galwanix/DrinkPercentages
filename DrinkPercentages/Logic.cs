using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkPercentages
{
    class Logic
    {
        private float containerSize,
            alcoholPercentage;
        private int containerNumber;

        public Logic()
        {
            ContainerCount = 3;
            ContainerSize = 0.75f;
            AlcoholPercentage = 3.5f;
        }

        public float ContainerSize
        {
            get => containerSize;
            set => containerSize = value > 0 ? value : 0;
        }
        public float AlcoholPercentage
        {
            get => alcoholPercentage;
            set => alcoholPercentage = (value > 0 && value < 100) ? value : 0;
        }
        public int ContainerCount
        {
            get => containerNumber;
            set => containerNumber = value > 0 ? value : 0;
        }
        public float DrinkVolume => ContainerSize * ContainerCount;
        public float AlcoholVolume => DrinkVolume * AlcoholPercentage / 100;
    }
}
