using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices.Classes
{
    internal class WaterTank
    {
        private double _unloadedWeight;
        private double _fillingLevel;
        private double _maxCapacity;
        private double _totalWeight;
        private static double _totalWaterVolume;

        public double UnloadedWeight { get => _unloadedWeight; set => _unloadedWeight = value; }
        public double FillingLevel { get => _fillingLevel; set => _fillingLevel = value; }
        public double MaxCapacity { get => _maxCapacity; set => _maxCapacity = value; }
        public double TotalWeight { get => _totalWeight; set => _totalWeight = value; }
        public static double TotalWaterVolume { get => _totalWaterVolume; set => _totalWaterVolume = value; }

        public WaterTank(double unloadedWeight, double fillingLevel, double maxCapacity)
        {
            _unloadedWeight = unloadedWeight;
            _fillingLevel = fillingLevel;
            MaxCapacity = maxCapacity;
            _totalWeight = _unloadedWeight + _fillingLevel;
            _totalWaterVolume += _fillingLevel;
        }

        public double FillWater(double water)
        {
            double fill = _fillingLevel += water;
            if (fill > _maxCapacity)
            {
                _fillingLevel = _maxCapacity;
                return fill - MaxCapacity; ;
            }
            return 0;
        }

        public double EmptyWater(double water)
        {
            double initialFillingLevel = _fillingLevel;
            double fillingLevel = _fillingLevel - water;
            if (fillingLevel <= 0)
            {
                _fillingLevel = 0;
                return initialFillingLevel;
            }
            _fillingLevel = fillingLevel;
            return _fillingLevel;
        }
    }
}
