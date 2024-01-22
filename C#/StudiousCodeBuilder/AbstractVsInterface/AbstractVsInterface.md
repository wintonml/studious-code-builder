# Abstract vs Interface
What are abstract and interface keywords? What do they mean? What do they do? When should you use them?

## [Abstract](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/abstract)
When the abstract keyword is used for a class or a class member it is used to indicate that the item is incomplete. They are useful to give structure to classes that
are similar (have similar method names or properties) but have different functionality in how the methods should function. It should be noted that the abstract classes
themselves cannot be instantiated, they are there to be inherited by other classes.

## [Interface](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/interface)
An interface is inherited by other classes and provides a contract for properties and methods that need to be implemented. You are able to state methods within the
interface, but you are not able to implement them and give them functionality within the interface, that happens within the class that inherits the interface.
Additionally, unlike abstract classes, there can be multiple interfaces inherited by a class.

[Interfaces](https://www.bytehide.com/blog/abstract-class-vs-interface-csharp) are often used in scenarios where multiple classes share a common behaviour but do not
share the same base class.

## [Abstract vs Interface] (https://www.bytehide.com/blog/abstract-class-vs-interface-csharp)
* Abstract classes can contain implemented methods, while interfaces only provide method signatures.
* Classes can inherit multiple interfaces, unlike abstract classes which only allow for one abstract class to be inherited.
* Abstract classes allow for more things to be stated in the contract, as they can state constructors and fields, unlike interfaces.

Abstract classes are generally used to create a base class that will be used in other classes. Interfaces are generally used in cases where you want to declare some behaviour that can be used across multiple unrelated classes.

I may have not shown the differences between the two, in the best way, in my example, but I wanted to make it fun and unique. In many cases, people will use shapes and
animals as the base for abstract classes and interfaces. The reason for that is they have common properties/actions that will be shared across more specific types
of them. For example, an animal will generally have a noise they make, number of feet and type of movement. These are features shared across all animals but would
defined differently depending on the specified animal.
