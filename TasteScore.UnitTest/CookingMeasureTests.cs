using TasteScore.Domain.CookingMeasure;
using TasteScore.Domain.CookingMeasure.Implemetations;

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
    }
}