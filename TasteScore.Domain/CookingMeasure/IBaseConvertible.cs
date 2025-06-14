namespace TasteScore.Domain.CookingMeasure
{
    public interface IBaseConvertible
    {
        IBaseConvertible FromBaseUnit(IBaseUnit measure);
        IBaseUnit ToBaseUnit();
    }
}