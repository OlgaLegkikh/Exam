// Используя обобщения разработайте несколько интерфейсов,
// первый - для сохрания/чтения последовательности объектов произвольного типа в/из источник данных,
// второй - для CRUD операций (взаимодействие с последоватеьностью объектов в памяти).
// Разработайте несколько классов, реализующих интерфейсы, разработанные ранее.
// Вид последовательности элементов и файл для хранения выберите самостоятельно при создании реализации интерфейса.
// Не забывайте про принципы ООП.

using System.Diagnostics;
using System.Xml.Linq;
using Task_6;

var ProductList = new ProductRepository();
ProductFileController fileController = new ProductFileController();

fileController.ProductFileWriter(ProductList.GetAll(), "product_list.json");
ProductListToConsole();

ProductList.Add(new Product { Category = "Игрушки", Name = "Мяч", Price = 16m });
ProductList.Remove(1);
var ball = new Product() { Id = 2, Category = "Игрушки", Name = "Барби", Price = 16m };
ProductList.Update(ball);

fileController.ProductFileWriter(ProductList.GetAll(), "product_list.json");
ProductListToConsole();

//Функция для дебага через консоль
void ProductListToConsole()
{
    foreach (Product item in fileController.ProductFileReader("product_list.json"))
    {
        Console.WriteLine(item.Id);
        Console.WriteLine(item.Name);
        Console.WriteLine(item.Price);
        Console.WriteLine(item.Category);
        Console.Write(Environment.NewLine);
    }
    Console.Write(Environment.NewLine);
}