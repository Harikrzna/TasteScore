namespace TasteScore.Domain.CookingMeasure
{
    public interface IIngredientUnit 
    {
        public string Name { get; }
        public string Symbol { get; }
        public double Value { get; init; }
    }
}