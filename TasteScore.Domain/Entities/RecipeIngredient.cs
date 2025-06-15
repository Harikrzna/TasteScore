using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasteScore.Domain.CookingMeasure;

namespace TasteScore.Domain.Entities
{
    public class RecipeIngredient
    {
        public Ingredient Ingredient { get; set; }
        public IIngredientUnit Measure { get; set; }

        public List<Nutrient> GetNutrientInfo()
        {
            if (Ingredient == null) throw new ArgumentNullException(nameof(Ingredient));

            return new List<Nutrient>();
        }
    }
}
