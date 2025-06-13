using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasteScore.Domain.CookingMeasure.Implemetations;

namespace TasteScore.Domain.CookingMeasure
{
    public static class CookingMeaureExtensions
    {
        public static TTarget ConvertTo<TTarget>(this ICookingMeasure source)
            where TTarget : ICookingMeasure, new()
        {
            double value=source.ToBaseValue();
            return (TTarget)new TTarget().FromBaseValue(value);
        }

    }
}
