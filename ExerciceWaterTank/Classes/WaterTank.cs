using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceWaterTank.Classes
{
    internal class WaterTank
    {
        private int _fillLevel;
        private int _maxCapacity;
        private int _weightEmpty;

        private static int _totalFillLevels = 0;

        public int FillLevel
        {
            get => _fillLevel; set
            {
                _totalFillLevels -= _fillLevel;
                _fillLevel = value;
                _totalFillLevels += _fillLevel;
            }
        }
        public int MaxCapacity { get => _maxCapacity; set => _maxCapacity = value; }
        public int WeightEmpty { get => _weightEmpty; set => _weightEmpty = value; }
        public int TotalWeight => _weightEmpty + _fillLevel;
        public static int TotalFillLevels => _totalFillLevels;

        public WaterTank(int fillLevel, int maxCapacity, int weightEmpty)
        {
            FillLevel = fillLevel;
            MaxCapacity = weightEmpty;
            WeightEmpty = weightEmpty;
        }

        public int Fill(int water)
        {
            if (water <= 0)
                return 0;
            if (FillLevel + water > MaxCapacity)
            {
                int excessWater = FillLevel + water - MaxCapacity;
                FillLevel = MaxCapacity;
                return excessWater;
            }
            else
            {
                FillLevel += water;
                return 0;
            }
        }

        public int Empty(int water)
        {
            if (water <= 0)
                return 0;
            return FillLevel -= water;
        }
    }
}
