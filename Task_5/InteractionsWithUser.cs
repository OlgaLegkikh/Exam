using System;
using System.Globalization;

namespace Task_5
{
	public class InteractionsWithUser
	{
		public InteractionsWithUser()
		{
		}
		public int OperationChoose()
		{
			try
			{
				Console.WriteLine("Выберите операцию: \n 1 - сложение, \n 2 - вычитание \n 3 - умножение \n 4 - деление \n 5 - факториал, \n 6 - возведение в степень \n 0 - выйти из программы");
				return Convert.ToInt32(Console.ReadLine());
			}
			catch (NullReferenceException)
			{
				Console.WriteLine("Выберите операцию: ");
				return OperationChoose();
			}
			catch (FormatException)
			{
				Console.WriteLine("Введите число: ");
				return OperationChoose();
			}
		}

		public double NumberAsk(string promt)
		{
			try
			{
				Console.WriteLine(promt);
				return double.Parse(s: Console.ReadLine(), CultureInfo.InvariantCulture);
			}
			catch (ArgumentNullException)
			{
				return NumberAsk(promt);
            }
			catch (FormatException)
			{
				return NumberAsk(promt);
			}
		}

		public void ShowResult(double result)
		{
			Console.WriteLine($"Результат: {result}");
			Console.WriteLine(Environment.NewLine);
		}
	}
}

