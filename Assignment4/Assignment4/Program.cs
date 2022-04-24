
/*
 * Test you Knowledge
 * Q1
 Generics allows us to design classes and methods but defer the specification of types until the class or methods are declared and called

 * Q2
 List<string> list = new List<string>();

 * Q3
 Two, TKey and TValue

 * Q4  T

 * Q5
 Method Add(T)

 * Q6
 Method Remove(T), RemoveAll(Predicate<T>)

 * Q7
  Add <T> after the class name

 * Q8  F

 * Q9  T

 * Q10 T

 */


using Assignment4;

// Practice working with Generics

// Test for Q1
Console.WriteLine("Test for Q1 MyStack :");
// Create an instance for MyStack with type char
MyStack<char> stack = new MyStack<char>();
Console.WriteLine("The initial size of the stack is {0}.", stack.Count());

Console.WriteLine("Push 'a', 'b', 'c' into stack in turn.");
stack.Push('a');
stack.Push('b');
stack.Push('c');

Console.WriteLine("The current size after three push operations is {0}.", stack.Count());

Console.WriteLine("The element popped out of the stack is '{0}'.", stack.Pop());

Console.WriteLine("The current size after pop operations is {0}.", stack.Count());

Console.WriteLine("--------------------------------------------------------------------------------");

// Test for Q2
Console.WriteLine("Test for Q2 MyList :");
// Create an instance for MyStack with type char
MyList<char> list = new MyList<char>();

Console.WriteLine("Add 'a', 'b', 'c' into list in turn.");
list.Add('a');
list.Add('b');
list.Add('c');

Console.WriteLine("Check whetheer contains 'a' : {0}", list.Contains('a'));     
char removedFromList = list.Remove(0);
Console.WriteLine("Remove the element at index 0, and what is removed is '{0}'", removedFromList);
Console.WriteLine("Check whetheer contains 'a' after removing it : {0}", list.Contains('a'));

Console.WriteLine("Insert 'd' into list at index 0.");
list.InsertAt('d', 0);
Console.Write("Current list: ");
for (int i = 0; i < list.Count(); i++) { Console.Write(list.Find(i) + " "); }
Console.WriteLine();

Console.WriteLine("Delete element from list at index 2.");
list.DeleteAt(2);
Console.Write("Current list: ");
for (int i = 0; i < list.Count(); i++) { Console.Write(list.Find(i) + " "); }
Console.WriteLine();

Console.WriteLine("Clear all elements in list");
list.Clear();
Console.Write("Current list: ");
for (int i = 0; i < list.Count(); i++) { Console.Write(list.Find(i) + " "); }
Console.WriteLine();

Console.WriteLine("--------------------------------------------------------------------------------");

// Test for Q3
Console.WriteLine("Test for Q2 GenericRepository :");
GenericRepository<Entity> entities = new GenericRepository<Entity> ();

Console.WriteLine("Add 1, 2, 3 into entities in turn.");
entities.Add(new Entity { Id = 1 });   
entities.Add(new Entity { Id = 2 });
entities.Add(new Entity { Id = 3 });

IEnumerable<Entity> entityList1 = entities.GetAll();
Console.Write("Current entity list: ");
foreach (Entity e in entityList1) { Console.Write(e.Id + " "); }
Console.WriteLine();

Entity entityWithId2 = entities.GetById(2);
entities.Remove(entityWithId2);
Console.WriteLine("After remove entity with id = 2, Current entity list is shown below using method Save(): ");
entities.Save();
