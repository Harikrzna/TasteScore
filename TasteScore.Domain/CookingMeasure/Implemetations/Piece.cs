using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasteScore.Domain.Entities;

namespace TasteScore.Domain.CookingMeasure.Implemetations
{
    public class Piece : ICountUnit
    {
        public string Name => "Piece";
        public string Symbol => "P";
        public double Value { get ; init; }
    }
}
