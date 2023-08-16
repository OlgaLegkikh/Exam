// Объявить коллекцию элементов типа int.
// Инициализировать его вручную или random.
// При помощи LINQ отсортировать коллекцию по возрастанию и вернуть вторую половину коллекции
// (округляя вверх если число элементов нечётное) остортированную по убыванию,
// где каждый элемент будет возведён в квадрат.
// PS не очень понятно у чему относится - (округляя вверх если число элементов нечётное)
// поэтому тут 2 решения в 1 случае используется банковское округление
// во втором случае число элементов в кусочке больше если это 1 кусочек(нечетный)


using System.Linq;

Random rnd = new Random();
var numbers = new List<int>();
int numbersLength = rnd.Next(10);
for (int i = 0; i < numbersLength; i++)
{
    numbers.Add(rnd.Next(100));
}

Console.Write("Созданная коллекция: ");
foreach (int i in numbers)
{
    Console.Write($"{i} ");
}
Console.Write(Environment.NewLine);

var newNumbers = from i in numbers.Order().Skip(((int)Math.Round((double)numbersLength) / 2)).OrderDescending()
                 select i * i;
Console.WriteLine("Решение в 1 запрос: ");
Console.Write("Отсортированная часть коллекции возведенная в квадрат: ");
foreach (int i in newNumbers)
{
    Console.Write($"{i} ");
}
Console.Write(Environment.NewLine);
Console.Write(Environment.NewLine);

Console.WriteLine("Решение пошагово: ");
var orderedNumbers = from i in numbers
                     orderby i
                     select i;
Console.Write("Отсортированная коллекция: ");
foreach (int i in orderedNumbers)
{
    Console.Write($"{i} ");
}
Console.Write(Environment.NewLine);

double elementsInChunk = ((double)orderedNumbers.Count() / 2);
int numberOfElements = (int)Math.Round(elementsInChunk, MidpointRounding.AwayFromZero);
var chunks = orderedNumbers.Chunk(numberOfElements);
int chunkNumber = 1;
List<int> chunkList = new List<int>();

foreach (int[] chunk in chunks)
{
    Console.Write($"Часть коллекции №{chunkNumber++}:");
    foreach(int item in chunk)
    {
        Console.Write($" {item}");
    }
    Console.Write(Environment.NewLine);
    chunkList = chunk.ToList();
}


var orderedChunk = from i in chunkList
                   orderby i descending
                   select i;

Console.Write("Отсортированная часть коллекции: ");
foreach (int i in orderedChunk)
{
    Console.Write($"{i} ");
}
Console.Write(Environment.NewLine);

var sqrChunk = from i in orderedChunk
               select i * i;

Console.Write("Отсортированная часть коллекции возведенная в квадрат: ");
foreach (int i in sqrChunk)
{
    Console.Write($"{i} ");
}
Console.Write(Environment.NewLine);