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
        public static TTarget ConvertTo<TTarget>(this IMassUnit source)
            where TTarget : IMassUnit, new()
        {
            IBaseUnit value=source.ToBaseUnit();
            return (TTarget)new TTarget().FromBaseUnit(value);
        }

    }
}
