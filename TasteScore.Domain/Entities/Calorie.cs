using TasteScore.Domain.CookingMeasure;

namespace TasteScore.Domain.Entities
{
    public class Calorie
    {
        public double Value { get; set; }
        public IIngredientUnit ForEvery { get; set; }
    }
}