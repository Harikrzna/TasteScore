namespace TasteScore.Domain.CookingMeasure
{
    public interface ICookingMeasure 
    {
        public string Name { get; }
        public string Symbol { get; }
        public double Value { get; init; }
        public double ToBaseValue();
        public ICookingMeasure FromBaseValue(double value);
    }
}