using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP
{
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T item);
    }
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
    }
    public class ColorSpecificaiton : ISpecification<Product>
    {
        private Color Color { get; set; }
        public ColorSpecificaiton(Color color)
        {
            Color = color;
        }
        public bool IsSatisfiedBy(Product item)
        {
            return item.Color == Color;
        }
    }
    public class SizeSpecification : ISpecification<Product>
    {
        private Size Size { get; set; }
        public SizeSpecification(Size size)
        {
            Size = size;
        }
        public bool IsSatisfiedBy(Product item)
        {
            return Size == item.Size;
        }
    }
    public class AndSpecification<T> : ISpecification<T>
    {
        private ISpecification<T> first, second;

        public AndSpecification(ISpecification<T> first, ISpecification<T> second)
        {
            this.first = first ?? throw new ArgumentNullException(nameof(first));
            this.second = second ?? throw new ArgumentNullException(nameof(second));
        }

        public bool IsSatisfiedBy(T item)
        {
            return first.IsSatisfiedBy(item) && second.IsSatisfiedBy(item);
        }
    }

    public class BetterFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
        {
            foreach (var item in items)
            {
                if (spec.IsSatisfiedBy(item))
                    yield return item;
            }
        }
    }
}
