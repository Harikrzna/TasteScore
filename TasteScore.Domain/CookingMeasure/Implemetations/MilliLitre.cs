using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasteScore.Domain.CookingMeasure.Implemetations
{
    public struct MilliLitre:IVolumeUnit
    {
        public string Name => "MilliLite";
        public string Symbol => "ml";
        public double Value { get; init; }
        public IBaseConvertible FromBaseUnit(IBaseUnit litre) => new MilliLitre(litre.Value*1000);
        public IBaseUnit ToBaseUnit() => new Litre(Value/1000);

        public MilliLitre(double value) => Value = value;
    }
}
