//Задача 54. Задайте двумерный массив.Напишите программу,которая упорядочит по убыванию элементы каждой строки двумерного массива.

/*
int [,] CreateRandom2dArray()
 { 
//       Console.WriteLine("введите количество строк m :");
//     int rows = Convert.ToInt32(Console.ReadLine());
//      Console.WriteLine("введите количество столбцов n :");
//     int columns = Convert.ToInt32(Console.ReadLine());
//      Console.WriteLine("введите минимальный диапозон :");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("введите максимальный диапозон :");
//     int maxValue = Convert.ToInt32(Console.ReadLine());
    int rows = 3;
    int columns = 4;
    int minValue=1;
    int maxValue=10;
    int[,]array = new int [rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j< columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    }
      return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j< array.GetLength(1); j++)
            Console.Write(array[i, j ] + " ");

        Console.WriteLine();   
    }

}

int[,] ChangeArray(int [,]array)
{
    int temp =0;
    
    for(int i= 0; i<array.GetLength(0);i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
        {
            for(int k=j+1; k<array.GetLength(1); k++ )
            {
                if(array[i,k]>array[i,j])
                {
                temp= array[i,k];
                array[i,k]=array[i,j];
                array[i,j]= temp;

                }

            }
        }
    }
    return array;
}
int [,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Console.WriteLine("Ваш массив :" );
int [,] Changearray= ChangeArray(myArray);

Show2dArray(Changearray);
*/

//Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/*
int [,] CreateRandom2dArray()
 { 
    Console.WriteLine("введите количество строк m :");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите количество столбцов n :");
    int columns = Convert.ToInt32(Console.ReadLine());
//      Console.WriteLine("введите минимальный диапозон :");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("введите максимальный диапозон :");
//     int maxValue = Convert.ToInt32(Console.ReadLine());
   
    int minValue=1;
    int maxValue=10;
    int[,]array = new int [rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j< columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    }
      return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j< array.GetLength(1); j++)
            Console.Write(array[i, j ] + " ");

        Console.WriteLine();   
    }
}   

int[] FaindMinSumm(int [,] array)
{
        int[] minSumm=new int[array.GetLength(0)];
    for(int i=0; i<array.GetLength(0);i++)
    {
        int summ=0;
        for(int j=0; j<array.GetLength(1); j++)
        {
            summ += array[i,j];
            minSumm[i]= summ;
        }
       /// Console.Write("Сумм :"+summ);
    }    
    return minSumm;         
}

int FaindMinStrok(int []array)
{
    int minString=0;
    int min= array[minString];
    for(int i =0; i<array.Length; i++)
    {
        if (array[i]<min)
        {
            min=array[i];
            minString = i;
        }
    }
    return minString;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
      Console.Write(array[i] + " ");

    Console.WriteLine();   
}
int [,] myArray = CreateRandom2dArray();

Show2dArray(myArray);
Console.WriteLine("Сумма в строках :" );

int[] FaindMinsumm= FaindMinSumm(myArray);

ShowArray(FaindMinsumm);

int Faind=FaindMinStrok(FaindMinsumm);
Console.Write("Наименьная сумма в строке: "+ (Faind+1));
*/
/// Задача 58. Задайте 2 матрицы. Напишите программу,которая будет находить произведение двух матриц
/// Есть претензии к коду,но надеюсь что в дальнейшем смогу сделать все правильно.
/*

int [,] CreateRandom2dArray()
 { 
     Console.WriteLine("введите количество строк m :");
     int rows = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("введите количество столбцов n :");
     int columns = Convert.ToInt32(Console.ReadLine());
//      Console.WriteLine("введите минимальный диапозон :");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("введите максимальный диапозон :");
//     int maxValue = Convert.ToInt32(Console.ReadLine());
    // int rows = 2;
    // int columns = 2;
    int minValue=1;
    int maxValue=10;
    int[,]array = new int [rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j< columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue);
    }
      return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j< array.GetLength(1); j++)
            Console.Write(array[i, j ] + " ");

        Console.WriteLine();   
    }
}

int[,]array1= CreateRandom2dArray();

int[,]array2= CreateRandom2dArray();

int [,]multiplyArray(int[,]array1,int[,]array2)
{
    int[,] newArray=new int[array1.GetLength(0),array2.GetLength(1)];
    if(array1.GetLength(0)!= array2.GetLength(1))
    {
        Console.WriteLine("произведение матриц вычислить нельзя ");        
    }
    else
    {
        for(int i=0; i<array1.GetLength(0);i++)
        {
            for(int j=0; j<array2.GetLength(1);j++)
            {
                newArray[i,j]=0;
                for(int k=0; k<array2.GetLength(0);k++)
                {
                    newArray[i,j]=newArray[i,j]+array1[i,k]*array2[k,j];
                }

            }
        }
    }
        return newArray;
}
Show2dArray(array1);
Console.WriteLine();
Show2dArray(array2);
int [,]array= multiplyArray(array1,array2);
Show2dArray(array);
*/
///Задача 60. Сформируйте трехмерный массив из неповторяющихся двузначных чисел. Напишите программу,которая будет построчновыводить массив, добавляя индексы каждого элемента.

int[] TwoDigitPositiveNumsArray()
{
    int[] array = Enumerable.Range(10, 90).ToArray();
    for (int i = 0; i < array.Length; i++)
    {
        int j = new Random().Next(0, 90);
        if (j != i)
        {
            var temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
    return array;
}
int[,,] Create3DArray(int[] array, int height, int width, int depth)
{
    int m = 0;
    int[,,] array3D = new int[height, width, depth];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                array3D[i, j, k] = array[m];
                m++;
            }
        }
    }
    return array3D;
}
void Print3DArray(int[,,] array)
{
    Console.WriteLine("\nЭлементы с индексами (i,j,k) в трехмерном массиве: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i, j, k] + " ");
                Console.Write($"({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
/*
try
{
    Console.Write("Введите высоту (количество строк): ");
    int height = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите ширину(количество столбцов): ");
    int width = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите глубину массива: ");
    int depth = Convert.ToInt32(Console.ReadLine());
    int[] array = TwoDigitPositiveNumsArray();
    int[,,] array3D = Create3DArray(array, height, width, depth);
    Print3DArray(array3D);
}
catch(Exception)
{
    Console.WriteLine("\nНедопустимый ввод!");
    Console.WriteLine("Введите числа больше 0 и (или) уменьшите размер массива.");
}