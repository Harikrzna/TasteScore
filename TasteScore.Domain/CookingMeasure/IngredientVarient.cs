using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasteScore.Domain.CookingMeasure
{
    public class IngredientVarient : IIngredientVarient
    {
        public SizeOption Size { get; set ; }
        public IngredientLocale Locale { get; set; }
        public double? GramPerCount { get; set; }
        public double? Density { get; set; }
    }
}
