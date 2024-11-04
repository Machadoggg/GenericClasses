
using GenericClasses.BasicGenericClass;
using GenericClasses.GenericsWithRestrictions;



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
