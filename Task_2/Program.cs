// Разработайте метод расширения для типа int, возвращающий значение в виде строки.
// Пример: Возвращает «1234» в виде «один два три четыре».
using System.Text;

Random rnd = new Random();

int numbers = rnd.Next(10000000);
Console.WriteLine(numbers);
Console.WriteLine(numbers.IntToString());

public static class IntExtension
{
    
    public static string IntToString(this int n)
    {
        string[] StrNumbers = new string[]
    {
    "ноль",
    "один",
    "два",
    "три",
    "четыре",
    "пять",
    "шесть",
    "семь",
    "восемь",
    "девять"
    };

        StringBuilder sb = new StringBuilder();
        var temp = new List<string>();

        if (n < 0)
        {
            sb.Append("минус ");
            n = n * -1;
        }

        do
        {

            int modulo = n % 10;
            temp.Add(StrNumbers[modulo]);
            n = (n - modulo) / 10;

        } while (n != 0);
        Console.WriteLine();
        temp.Reverse();
        string result = sb.AppendJoin(' ', temp).ToString();

        return result ;
    }
}





