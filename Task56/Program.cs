
    Console.Write("Введите число столбцов массива: ");
    int stolb = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число строк массива: ");
    int strok = Convert.ToInt32(Console.ReadLine());
    if(strok == stolb)
    {
        Console.WriteLine("Заданный массив не является прямоугольным!");
    }
int[,] matrix = new int[strok, stolb];

void Fullmatr(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    Console.WriteLine();
    }
}

void Printmatr(int[,] mat)
{
    for(int k = 0; k < mat.GetLength(0); k++)
    {
        for(int l = 0; l < mat.GetLength(1); l++)
        {
            Console.Write(mat[k, l]);
        }
    Console.WriteLine();
    }
}

void StrSum(int[,] ma)
{
    int minsum = Int32.MaxValue;
    int istr = 0;

    for (int i = 0; i < ma.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < ma.GetLength(1); j++)
        {
            sum = sum + ma[i, j];        
        }
        if (sum < minsum)
        {
             minsum = sum;
             istr++;
        }
    }
    Console.WriteLine($"{istr} является строкой с наименьшей суммой элементов");
}


Fullmatr(matrix);
Printmatr(matrix);
StrSum(matrix);
