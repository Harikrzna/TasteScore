using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasteScore.Domain.CookingMeasure.Implemetations
{
    public struct Gram : IMassUnit,IBaseUnit
    {
        public string Name => "Gram";
        public string Symbol => "g";
        public double Value { get; init; }
        public string ToString() => $"{Value} {Symbol}";

        public IBaseConvertible FromBaseUnit(IBaseUnit measure)=>measure;
        public IBaseUnit ToBaseUnit() => this;

        public static Gram operator +(Gram first, Gram second) => new Gram(first.Value + second.Value);

        public Gram(double value)
        {
            Value = value;
        }

        

    }
}
