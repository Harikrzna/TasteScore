using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasteScore.Domain.CookingMeasure
{
    public interface IIngredientVarient
    {
        public SizeOption Size { get; set; }
        public IngredientLocale Locale { get; set; }
        public double GramPerPiece { get; set; }
    }
}
