using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasteScore.Domain.CookingMeasure.Implemetations;
using TasteScore.Domain.Entities;

namespace TasteScore.Domain.CookingMeasure
{
    public static class CookingMeaureExtensions
    {
        public static TTarget ConvertTo<TTarget>(this IMassUnit source)
            where TTarget : IMassUnit, new()
        {
            IBaseUnit value=source.ToBaseUnit();
            return (TTarget)new TTarget().FromBaseUnit(value);
        }

        public static TTarget ConvertTo<TTarget>(this IVolumeUnit source)
            where TTarget : IVolumeUnit, new()
        {
            IBaseUnit value = source.ToBaseUnit();
            return (TTarget)new TTarget().FromBaseUnit(value);
        }

        public static TTarget ConvertTo<TTarget>(this IMassUnit quantity, double density)
            where TTarget: IVolumeUnit, new()
        {
            if(quantity is null)
            {
                throw new ArgumentNullException(nameof(quantity));
            }

            if (density <= 0)
            {
                throw new ArgumentException($"{nameof(density)}  is zero or -ve");
            }

            Kilogram kg=quantity.ConvertTo<Kilogram>();
            var litreValue=kg.Value/(density*1000);
            Litre litre=new Litre(litreValue);
            TTarget targetVolume=litre.ConvertTo<TTarget>();
            return targetVolume;

        }

        public static TTarget ConvertTo<TTarget>(this IVolumeUnit quantity, double density)
            where TTarget : IMassUnit, new()
        {
            if (quantity is null)
            {
                throw new ArgumentNullException(nameof(quantity));
            }

            if (density <= 0)
            {
                throw new ArgumentException($"{nameof(density)}  is zero or -ve");
            }

            Litre litre =quantity.ConvertTo<Litre>();
            var kgValue = litre.Value*1000 * density;
            Kilogram kg = new Kilogram(kgValue);
            TTarget targetWeight = kg.ConvertTo<TTarget>();
            return targetWeight;
        }

        public static TTarget ConvertTo<TTarget>(this IMassUnit quantity,Gram gramPerCount)
            where TTarget : ICountUnit, new()
        {
            if (quantity is null)
            {
                throw new ArgumentNullException(nameof(quantity));
            }

            if (gramPerCount.Value <= 0)
            {
                throw new ArgumentException($"{nameof(gramPerCount)} is zero or -ve");
            }

            Gram gram = quantity.ConvertTo<Gram>();
            double noOfPieces = gram.Value/gramPerCount.Value;
            Piece piece=new Piece(noOfPieces);
            return (TTarget)(ICountUnit)piece;

        }

        public static TTarget ConvertTo<TTarget>(this ICountUnit quantity, Gram gramPerCount)
            where TTarget : IMassUnit, new()
        {
            if (quantity is null)
            {
                throw new ArgumentNullException(nameof(quantity));
            }

            if (gramPerCount.Value <= 0)
            {
                throw new ArgumentException($"{nameof(gramPerCount)} is zero or -ve");
            }

            Gram gram = new Gram(quantity.Value*gramPerCount.Value);
            TTarget targetMass = gram.ConvertTo<TTarget>();
            return targetMass;

        }

        public static TTarget ConvertTo<TTarget>(this ICountUnit quantity, Gram gramPerCount,double density)
            where TTarget : IVolumeUnit, new()
        {
            if (quantity is null)
            {
                throw new ArgumentNullException(nameof(quantity));
            }

            if (gramPerCount.Value <= 0)
            {
                throw new ArgumentException($"{nameof(gramPerCount)} is zero or -ve");
            }

            if (density <= 0) 
            {
                throw new ArgumentException($"{nameof(density)} is zero or -ve");
            }

            Gram gram=quantity.ConvertTo<Gram>(gramPerCount);
            TTarget volume=gram.ConvertTo<TTarget>(density);
            return volume;

        }

        public static TTarget ConvertTo<TTarget>(this IVolumeUnit quantity, Gram gramPerCount, double density)
            where TTarget : ICountUnit, new()
        {
            if (quantity is null)
            {
                throw new ArgumentNullException(nameof(quantity));
            }

            if (gramPerCount.Value <= 0)
            {
                throw new ArgumentException($"{nameof(gramPerCount)} is zero or -ve");
            }

            if (density <= 0)
            {
                throw new ArgumentException($"{nameof(density)} is zero or -ve");
            }

            Gram gram = quantity.ConvertTo<Gram>(density);
            TTarget count = gram.ConvertTo<TTarget>(gramPerCount);
            return count;
        }

    }
}
