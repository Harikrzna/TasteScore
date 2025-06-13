namespace TasteScore.Domain.Entities
{
    public class Recipe
    {
        public Guid UniqueId { get; set; }
        public string Name { get; set; }
        public List<RecipeIngredient> Ingredients { get; set; }
        public List<PreparationStep> PreparationSteps { get; set; }
        public int Serving { get; set; }
        public int ServingSize { get; set; }
        public string Description { get; set; }

    }
}
