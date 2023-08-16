// Разработайте класс содержащий произвольный публичный метод и событие.
// После 10 вызовов метода у любых экземпляров разработанного класса
// необходимо вызвать событие и информировать об этом пользователя.
// Обработку события произвести либо при помощи анонимного метода, либо при помощи лямбда-вырожения.

delegate int Sum(int number);

class Program
{
    static Sum SomeVar()
    {
        int result = 0;

        // Вызов анонимного метода
        Sum del = delegate (int number)
        {
            for (int i = 0; i <= number; i++)
                result += i;
            return result;
        };
        return del;
    }

    static void Main()
    {
        Sum del1 = SomeVar();

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Cумма {0} равна: {1}", i, del1(i));
        }

        Console.ReadLine();
    }
}