
using GenericClasses.GenericInMethods;
using GenericClasses.GenericBasicClass;
using GenericClasses.GenericsWithRestrictions;
using GenericClasses.GenericWithInterfaces;
using GenericClasses.GenericsWithDelegates;
using GenericClasses.GenericsWithComparison;
using GenericClasses.GenericsWithHeritage;



//1: Basic Generic Class
//permite almacenar datos de cualquier tipo.
var intBox = new Box<int>(123);
intBox.DisplayContent();

var stringBox = new Box<string>("Hello");
stringBox.DisplayContent();


//2: Generics with Restrictions
//restringe el tipo genérico a ciertos tipos, como clases específicas o interfaces.
var repo = new Repository<string>();
repo.Add("Item 1");
repo.Add("Item 2");

foreach (var item in repo.GetAll())
{
    Console.WriteLine(item);
}



//3: Genéricos con Interfaces
// Los genéricos también pueden implementar interfaces para mayor flexibilidad en su uso.Uso:
IRepository<int> intRepo = new MemoryRepository<int>();
intRepo.Add(10);
intRepo.Add(11);
Console.WriteLine(intRepo.Get(0));
Console.WriteLine(intRepo.Get(1));


//4: Genéricos en Métodos
//Los métodos dentro de una clase pueden ser genéricos sin que toda la clase sea genérica.
Utility.Print(42);
Utility.Print(8.4);
Utility.Print("Generics in C#");



//5: Genéricos con Delegados
//Podemos usar genéricos para crear delegados que acepten cualquier tipo.
Transformer<int> squareInt = TransformerDemo.Square;
Console.WriteLine(squareInt(5)); // Output: 25

Transformer<double> squareDouble = TransformerDemo.Square;
Console.WriteLine(squareDouble(3.5)); // Output: 12.25



//6: Genéricos con Comparación (Método de Ordenamiento)
//Las clases genéricas también se pueden usar para crear algoritmos reutilizables, 
//como métodos de ordenamiento.
var numbers = new List<int> { 3, 1, 4, 1, 5, 9 };
var sorter = new Sorter<int>();
sorter.Sort(numbers);

foreach (var number in numbers)
{
    Console.WriteLine($"{number}");
}


//7: Clases Genéricas con Herencia
//Puedes crear una clase genérica que herede de otra clase genérica, 
//extendiendo sus capacidades.
var labeledContainer = new LabeledContainer<int>
{
    Content = 100,
    Label = "Integer Container"
};

Console.WriteLine($"{labeledContainer.Label}: {labeledContainer.Content}");