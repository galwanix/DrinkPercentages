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
            set
            {
                if (value >= 0)
                    containerSize = value;
                else
                    throw new ArgumentException(
                        "ContainerSize: Value outside of expected range: ContainerSize = "
                        + value
                        + "; Default bounds: X>=0");
            }
        }
        public float AlcoholPercentage
        {
            get => alcoholPercentage;
            set
            {
                if (value >= 0 && value <= 100)
                    alcoholPercentage = value;
                else
                    throw new ArgumentException(
                        "AlcoholPercentage: Value outside of expected range: AlcoholPercentage = "
                        + value
                        + "; Default bounds: 0<=X<=100");
            }
        }
        public int ContainerCount
        {
            get => containerNumber;
            set
            {
                if (value >= 0)
                    containerNumber = value;
                else
                    throw new ArgumentException(
                        "ContainerCount: Value outside of expected range: ContainerCount = "
                        + value
                        + "; Default bounds: X>=0");
            }
        }
        public float DrinkVolume => ContainerSize * ContainerCount;
        public float AlcoholVolume => DrinkVolume * AlcoholPercentage / 100;
    }
}
