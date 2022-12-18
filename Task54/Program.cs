Console.WriteLine("Выберите задание: ");
Console.WriteLine("Задание 54. Упорядочевание элементов массива по строчно");
Console.WriteLine("Задание 56. Поиск строки с наименьшей суммой элементов");
Console.WriteLine("Задание 58. Произведение 2х массивов");
Console.WriteLine("Задание 60. Трехмерный массив с индексом каждого элемента");
Console.WriteLine("Задание 62. Спиральное заполнение массива");
int n = Convert.ToInt32(Console.ReadLine());

switch (n){
    case 54: Task54();
    break;
    case 56: Task56();
    break;
    case 58: Task58();
    break;
    case 60: Task60();
    break;
    case 62: Task62();
    break;
    default:
    break;
}

void Task54()
{
//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива. (можно использовать готовую функцию)
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array2d = new int [m, n];
Random random = new Random();
// генерация массива
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array2d[i, j] = random.Next(0, 10);
        Console.Write (array2d[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

// сортировка по строкам
int[] arr = new int [n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
      arr[j] = array2d[i, j];
    Array.Sort(arr);
    for (int j = 0; j < n; j++)
      array2d[i, j] = arr[j];
}

// Вывод результата 
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
        Console.Write (array2d[i, j] + " ");
    Console.WriteLine();
}
}

void Task56()
{
//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов. 
//(можно использовать готовую функцию)
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array2d = new int [m, n];
Random random = new Random();
// генерация массива
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array2d[i, j] = random.Next(0, 10);
        Console.Write (array2d[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

// поиск строки с наименьшей суммой
int minSum = 10 * n; // максимально возможная сумма элементов строки
int sum = 0;
int number = 0;
for (int i = 0; i < m; i++)
{
    sum = 0;
    for (int j = 0; j < n; j++)
        sum = sum + array2d[i, j];
    if (sum < minSum)
        {
            minSum = sum;
            number = i + 1;
        }
}
Console.WriteLine("Наименьшая сумма равна {0} и находится в строке № {1}", minSum, number);
}

void Task58()
{
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите количество строк в массиве №1 ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве №1 ");
int n1 = Convert.ToInt32(Console.ReadLine());

int[,] A = new int [m1, n1];
Random random1 = new Random();
// генерация массивов
Console.WriteLine("Массив № 1");
for (int i = 0; i < m1; i++)
{
    for (int j = 0; j < n1; j++)
    {
        A[i, j] = random1.Next(0, 10);
        Console.Write (A[i, j] + " ");
    }
    Console.WriteLine( );
}
Console.WriteLine();

Console.WriteLine("Введите количество строк в массиве №2 ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве №2");
int n2 = Convert.ToInt32(Console.ReadLine());

int[,] B = new int [m2, n2];
Random random2 = new Random();
Console.WriteLine("Массив № 2");
for (int i = 0; i < m2; i++)
{
    for (int j = 0; j < n2; j++)
    {
        B[i, j] = random2.Next(0, 10);
        Console.Write(B[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

if (n1 == m2)
{
// Умножение матриц
// Произведение матрицы A размера m×n и матрицы B размера n×k — это матрица C размера m×k. 

int[,] C = new int [m1,n2];
Console.WriteLine("Итоговый массив " );
for (int i = 0; i < m1; i++)
   {
    for (int j = 0; j < n2; j++)
    {
        for (int k = 0; k < n1; k++)
          C[i, j] = C[i, j] + A[i, k] * B[k, j];

        Console.Write(C[i, j] + " ");
    }
    Console.WriteLine();
   }
}
else Console.WriteLine("Умножение не возможно, т.к. количесво стобцов первой матрицы должно быть равно количеству строк второй марицы");
}

void Task60()
{
//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine("Введите параметры для трехмерного массива");
Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите глубину массива");
int k = Convert.ToInt32(Console.ReadLine());

int[, ,] array3d = new int [m, n, k];
Random random = new Random();

// генерация массивa 

Console.WriteLine();
int Zn = random.Next(10, 14);  // Переменная со случайным значением от 10 до 13, необходима для заполнения массива без повторения значений элемента
for (int x = 0; x < m; x++)
{
    for (int y = 0; y < n; y++)
    {
        for (int z = 0; z < k; z++)  
            {
            array3d[x, y , z] = Zn;  // Элементу массива присваиваем переменную, которая увеличивается в каждом цикле на случайное число от 1 до 4.
            Zn = Zn + random.Next(1,5); // это необходимо чтобы элементы массива были двухзначными числами.
            Console.Write(array3d[x, y, z] +" " + "({0},{1},{2}) ",  x, y, z);
            }
        Console.WriteLine();  
    }    
Console.WriteLine(); 
}
}

void Task62()
{
//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int m = 4;
int maxNext = m * m;
int[,] array2d = new int [m, m];
int next = 1;
int min = 0;
int max = m - 1;
for (int i = 0; i < m; i++)
  for (int j = 0; j < m; j++)
    array2d[i, j] = 0; 

while (next <= maxNext)  // Условие пока не все заполненно
{
  int i = min;
  int j = min;

  while (array2d[i, j] == 0)  // прямой ход
  { 
    array2d[i, j] = next;
    Console.WriteLine ("({0},{1}) {2}", i, j, next);
    next++;
    if (j < max)
      j++;
    else if (i < max)
          i++;
  }
  j--;
  while (array2d[i, j] == 0)   // обратный ход
  { 
    array2d[i, j] = next;
    Console.WriteLine ("({0},{1}) {2}", i, j, next);
    next++;
    if (j > min)
      j--;
    else if (i > min)
          i--;
  }
  min++;
  max--;
}

for (int i = 0; i < m; i++)
  { 
    for (int j = 0; j < m; j++)
      Console.Write ("{0,3:D}", array2d[i, j]);
    Console.WriteLine();
  }
}
