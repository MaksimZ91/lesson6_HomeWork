Console.Clear();
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
// void countNumber ()
// {
//  Console.Write("Введите желаемое количество чисел:  ");
//  int m = Convert.ToInt32(Console.ReadLine());
//  int count = 0;
//  for (int i = 0; i < m; i++)
//  {
//     Console.Write("Введите число:  ");
//     int k = Convert.ToInt32(Console.ReadLine());
//     if(k > 0)
//       count++;
//  }
// Console.Write($"Вы ввели {count} чисел больше 0."); 
// }

// countNumber();


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.Write("Введите значение координаты b1:  ");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите значение координаты k1:  ");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите значение координаты b1:  ");
// double b2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите значение координаты k1:  ");
// double k2 = Convert.ToDouble(Console.ReadLine());

// double[] findePointintersec(double b1, double b2, double k1, double k2 )
// {
//   double x = (b2-b1)/(k1-k2);
//   double y = k1*(b2-b1)/(k1-k2)+b1;
//   double[] result = {x, y};
//   return result;
// } 
// Console.WriteLine("Точка пересечения двух прямых находится по координатам: [ " + string.Join(", ", findePointintersec(b1, b2, k1, k2)) + " ]");



//Дополнительная задача # 1

// void initMatrix (int[,] matrix)
// {
  
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for(int j = 0; j < matrix.GetLength(1); j++)
//     {
//       matrix[i,j] = new Random().Next(1,11);
//     }
//   }
// }

// void printMatrix (int[,] matrix)
// {
  
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for(int j = 0; j < matrix.GetLength(1); j++)
//     {
//       Console.Write($" {matrix[i,j]}");
//     }
//     Console.WriteLine();
//   }  
// }

// void revers (int[,] matrix)
// {
//   for(int i = 0; i < matrix.GetLength(0)/2; i++)
//   {
//     for(int j = 0; j< matrix.GetLength(1); j++)
//     {
//       int buf = matrix[i,j];
//       matrix[i,j]=matrix[matrix.GetLength(0)-1-i, j];
//       matrix[matrix.GetLength(0)-1-i, j] = buf;
//     }
//   }
// } 


// Console.Write("Введите число строк матрицы:  ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число столбцов матрицы:  ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[n,m];

// initMatrix(matrix);
// Console.WriteLine("Исходная матрица: ");
// printMatrix(matrix);
// revers(matrix);
// Console.WriteLine("Транспонированная по горизонтали матрица: ");
// printMatrix(matrix);


//Дополнительная задача # 2

Console.Write("Введите строку длтнной от 1 до 8 символов: ");
string N = Console.ReadLine();
while ( N.Length  > 8)
{
  Console.Write("Введите строку длтнной от 1 до 8 символов: ");
  N = Console.ReadLine();
}
char[] str = N.ToCharArray();

void changeChar (int start, char[] str, int lenght)
{
  if (str[start] == str[lenght-1])
  {
    string.Concat(str);
    Console.WriteLine(string.Concat(str));
  }
  else
  {
      for(int i = start; i < str.Length; i++)
      {
        swap(ref str[i], ref str[start]);         
        changeChar(start+1, str, str.Length);  
        swap(ref str[start], ref str[i]);
      }
    }
}

void swap (ref char a, ref char b)
{
  char buff = a;
  a = b;
  b = buff;
}

changeChar(0, str, N.Length);


