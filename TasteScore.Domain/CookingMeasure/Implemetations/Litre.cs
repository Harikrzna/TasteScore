using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasteScore.Domain.CookingMeasure.Implemetations
{
    public struct Litre : IVolumeUnit,IBaseUnit
    {
        public string Name => "Lite";
        public string Symbol => "L";
        public double Value { get; init; }
        public IBaseConvertible FromBaseUnit(IBaseUnit litre)=>litre;
        public IBaseUnit ToBaseUnit()=>this;

        public Litre(double value) => Value = value;
    }
}
