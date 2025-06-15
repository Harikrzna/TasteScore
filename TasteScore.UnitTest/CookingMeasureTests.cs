using TasteScore.Domain.CookingMeasure;
using TasteScore.Domain.CookingMeasure.Implemetations;
using TasteScore.Domain.Entities;

namespace TasteScore.UnitTest
{
    public class CookingMeasureTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ToString_Gram_ValueAndUnitIsDisplayed()
        {
            Gram quantity = new Gram(10);

            Assert.That(quantity.ToString() == "10 g");
        }

        [Test]
        public void ToString_Kilogram_ValueAndUnitIsDisplayed()
        {
            Kilogram quantity = new Kilogram(10);

            Assert.That(quantity.ToString() == "10 Kg");
        }

        [Test]
        public void ConvertTo_GramToKilogram_SuccessfullyConverted()
        {
            Gram grams = new Gram(1000);
            Kilogram kilos=grams.ConvertTo<Kilogram>();
            Assert.That(kilos.Value == 1);
        }

        [Test]
        public void ConvertTo_KilogramToGram_SuccessfullyConverted()
        {
            Kilogram kilo = new Kilogram(1);
            Gram gram = kilo.ConvertTo<Gram>();
            Assert.That (gram.Value == 1000);
        }

        [Test]
        public void ConvertTo_LitreToMilliLitre_SuccessfullyConverted()
        {
            Litre litre = new Litre(1);
            MilliLitre milliLitre = litre.ConvertTo<MilliLitre>();
            Assert.That(milliLitre.Value == 1000);
        }

        [Test]
        public void GetNutrientInfo_RecipeIngredientInPiece_SuccessfullyConverted()
        {
            IngredientVarient varient = new() { Size = SizeOption.Medium, Locale = IngredientLocale.SouthIndian, GramPerPiece = 130 };
            List<NutrientLabel> nutrientsLabel = new() { new NutrientLabel() { NutrientId=new Guid(),Name = "Carbohydrates", Qty = 11, ForEvery = new Gram(130) } };
            Ingredient ingredient = new() { Id=1,Name="Onion",Nutrients=nutrientsLabel,Varient=varient};
            Piece piece = new (1);
            RecipeIngredient recipeIngredient = new() { Ingredient = ingredient, Measure = piece };

            var resultNutrient=recipeIngredient.GetNutrientInfo().First();
            var expectedNutrient = new Nutrient() { NutrientId = nutrientsLabel[0].NutrientId,Name = "Carbohydrates", Qty = 11 };
            Assert.Equals(resultNutrient, expectedNutrient);
        }
    }
}