/*
 * Test your knowledge
 * Q1
 public : accessible from everywhere in a project
 private : accessible only inside a class or a structure
 protected : accessible inside the class and in all classes that derive from that class
 internal : accessible to classes defined within the current project assembly
 protected internal : accessible to the protected internal member only in the same assembly or in a derived class in other assemblies
 private protected : accessible to the members inside the containing class or in a class that derives from a containing class, but only in the same assembly(project)

 * Q2
 1) Static members can only be accessed within the static methods; Readonly fields can be initialized at declaration or in the constructor, used for sun-time constants;
    he constant fields must be initialized at the time of declaration, used for compile-time constants.
 2) Value of the static members can be modified using ClassName.StaticMemberName; Readonly variable cannot be modified at run-time. It can only be initialized or changed in the constructor;
    Constant variables cannot be modified after declaration
 3) Static members can be accessed using ClassName.StaticMemberName, but cannot be accessed using object; Readonly members can be accessed using object, but not ClassName.ReadOnlyVariableName;
    Const members can be accessed using ClassName.ConstVariableName, but cannot be accessed using object

 * Q3
 a special type of subroutine called to create an object. It prepares the new object for use, often accepting arguments that the constructor uses to set required member variables

 * Q4
 It provides a special ability to implement the functionality of a single class into multiple files and all these files are combined into a single class file when the application is compiled

 * Q5
 A tuple is a data structure that contains a sequence of elements of different data types. It can be used where you want to have a data structure to hold an object with properties,
 but you don't want to create a separate type for it

 * Q6
  record keyword is to define a reference type that provides built-in functionality for encapsulating data

 * Q7
 overloading : multiple methods in the same classs, same method name, but diiferent parameter lists
 overriding : happens between base class and derived class, same method signature(accesss modifier, method name, same input parameters), derived classes can have different implementations for the same methods

 * Q8
 A field is a variable of any type that is declared directly in a class; A property is a member that provides a flexible mechanism to read, write or compute the value of a private field
 A field can be used to explain the characteristics of an object or a class; A property can be used to set and receive values of a field

 * Q9
 By assigning default values for the parameter

 * Q10
 Interface defines the a contract which is implemented by the derived classes.
 Interface vs. Abstract class
 1) Interface supports multiple inheritance but abstract class does not
 2) Interface can not have instanced constructor but abstract class can have
 3) Interface has by default all members abstract and public, but abstract class can have abstract and concrete members
 4) Interface can not have fields but abstract class can have fields.

 * Q11
 The accessibility level should be protected since interface can be implemented by derived class and derived class can get access to the interface's members.
 
 * Q12  T
 
 * Q13  T
 
 * Q14  F
 
 * Q15  F
 
 * Q16  T
 
 * Q17  T
 
 * Q18  T
 
 * Q19  F
 
 * Q20  F
 
 * Q21  T
 
 * Q22  F
 
 * Q23  T
 
 */


