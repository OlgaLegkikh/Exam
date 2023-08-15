// Объявить двумерный массив для элементов типа int.
// Инициализировать его вручную или random.
// Присвоить значение 1 всем элементам массива, которые лежат выше главной диагонали.
// PS Главной диагональю матрицы называется диагональ, проведённая из левого верхнего угла матрицы в правый нижний.

var random = new Random();


int[,] numbers = new int[random.Next(10), random.Next(10)];

int rows = numbers.GetUpperBound(0) + 1;    // количество строк
int columns = numbers.Length / rows;        // количество столбцов
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
       
            numbers[i, j] = random.Next(1000);
        
    }
    Console.WriteLine();
}

arrayPrint(numbers);
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        if (i < j)
        {
            numbers[i, j] = 1;
        }
    }
    Console.WriteLine();
}
arrayPrint(numbers);


void arrayPrint(int[,] array)
{
    int rows = array.GetUpperBound(0) + 1;    
    int columns = array.Length / rows;        
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
           
                Console.Write($"{array[i, j]} \t");
            
        }
        Console.WriteLine();
    }
}