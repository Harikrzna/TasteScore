using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasteScore.Domain.CookingMeasure;

namespace TasteScore.Domain.Entities
{
    public class NutrientLabel
    {
        public Guid NutrientId { get; set; }
        public string Name { get; set; }
        public double Qty { get; set; }
        public IIngredientUnit ForEvery { get; set; }
    }
}
