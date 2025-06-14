namespace TasteScore.Domain.CookingMeasure
{
    public interface IBaseUnit : IBaseConvertible
    {
        public double Value { get; init; }
    }
}