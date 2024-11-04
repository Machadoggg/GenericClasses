
using GenericClasses.GenericInMethods;
using GenericClasses.GenericBasicClass;
using GenericClasses.GenericsWithRestrictions;
using GenericClasses.GenericWithInterfaces;



//Basic Generic Class
//permite almacenar datos de cualquier tipo.
var intBox = new Box<int>(123);
intBox.DisplayContent();

var stringBox = new Box<string>("Hello");
stringBox.DisplayContent();


// Generics with Restrictions
//restringe el tipo genérico a ciertos tipos, como clases específicas o interfaces.
var repo = new Repository<string>();
repo.Add("Item 1");
repo.Add("Item 2");

foreach (var item in repo.GetAll())
{
    Console.WriteLine(item);
}



// Genéricos con Interfaces
// Los genéricos también pueden implementar interfaces para mayor flexibilidad en su uso.Uso:
IRepository<int> intRepo = new MemoryRepository<int>();
intRepo.Add(10);
intRepo.Add(11);
Console.WriteLine(intRepo.Get(0));
Console.WriteLine(intRepo.Get(1));


//Genéricos en Métodos
//Los métodos dentro de una clase pueden ser genéricos sin que toda la clase sea genérica.
Utility.Print(42);
Utility.Print(8.4);
Utility.Print("Generics in C#");