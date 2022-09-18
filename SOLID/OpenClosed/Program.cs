using SOLID.OCP;

var apple = new Product("Apple", Color.Green, Size.Small);
var tree = new Product("Tree", Color.Green, Size.Large);
var house = new Product("House", Color.Blue, Size.Large);

Product[] products = { apple, tree, house };

var pf = new ProductFilter();
Console.WriteLine("Green products (old):");

foreach (var p in pf.FilterByColor(products, Color.Green))
    Console.WriteLine($" - {p.Name} is green");

// ^^ BEFORE

// vv AFTER
var filter = new BetterFilter();
Console.WriteLine("Green products (new)");
foreach (var item in filter.Filter(products, new ColorSpecificaiton(Color.Green)))
{
    Console.WriteLine($" - {item.Name} is green");
}

Console.WriteLine("Large products (new)");
foreach (var item in filter.Filter(products, new SizeSpecification(Size.Large)))
{
    Console.WriteLine($" - {item.Name} is large");
}

Console.WriteLine("Large blue products (new)");
foreach (var item in filter.Filter(products, 
    new AndSpecification<Product>(new ColorSpecificaiton(Color.Blue), new SizeSpecification(Size.Large))))
{
    Console.WriteLine($" - {item.Name} is large & blue");
}
