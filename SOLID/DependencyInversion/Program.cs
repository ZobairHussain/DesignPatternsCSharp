using DependencyInversion;

Console.WriteLine("High level part of the system does not depend low level part of the system directly");
Console.WriteLine("instead they should depend some kind of abstruction.");


var parent = new Person { Name = "John" };
var child1 = new Person { Name = "Chris" };
var child2 = new Person { Name = "Matt" };

// low-level module
var relationships = new Relationships();
relationships.AddParentAndChild(parent, child1);
relationships.AddParentAndChild(parent, child2);

new Research(relationships);