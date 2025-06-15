using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasteScore.Domain.CookingMeasure;

namespace TasteScore.Domain.Entities
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Calorie Energy { get; set; }
        public List<NutrientLabel> Nutrients { get; set; }
        public IIngredientVarient? Varient { get; set; }

    }
}
