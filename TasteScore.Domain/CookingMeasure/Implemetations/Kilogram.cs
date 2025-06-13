using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasteScore.Domain.CookingMeasure.Implemetations
{
    public readonly struct Kilogram : ICookingMeasure
    {

        public string Name => "Kilogram";
        public string Symbol => "Kg";
        public double Value { get; init; }
        public string ToString() => $"{Value} {Symbol}";
        public double ToBaseValue()=> Value*1000;
        public ICookingMeasure FromBaseValue(double value)=> new Kilogram(value/1000);
        public static Kilogram operator + (Kilogram first, Kilogram second) => new Kilogram(first.Value + second.Value);
        public Kilogram(double value)=> Value = value;
        
    }
}
