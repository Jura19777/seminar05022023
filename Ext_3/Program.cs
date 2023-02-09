//В прямоугольной матрице найти строку с наименьшей суммой элементов

int ReadInt(string str)
{
    Console.Write(str);
    return int.Parse(Console.ReadLine()!);
}

void Otvet(int[,] mtr)
{   
    int[] mtrM = new int [mtr.GetLength(0)];
    int sum = 0;
    for (int i=0; i<mtr.GetLength(0); i++)
        for (int j=0; j<mtr.GetLength(1); j++)
        mtrM[i] = mtrM[i]+mtr[i,j];
    
    for (int i=0; i<mtrM.GetLength(0)-1; i++)
        for (int j=1; j<mtrM.GetLength(0); j++)
        if (mtrM[i]>mtrM[j])
            sum = j;
            else
                sum = i;
    
    Console.WriteLine("Строка с наименьшей суммой элементов");
    for (int j=0; j<mtr.GetLength(1); j++)  
        Console.Write($"{mtr[sum,j]} ");
}

int[,] CreateMatrix(int m, int n)
{
    Random rnd = new Random();
    int[,] mtr = new int [m,n];
    for (int i=0; i<mtr.GetLength(0); i++)
        for (int j=0; j<mtr.GetLength(1); j++)
            mtr[i,j] = rnd.Next(10);
        return mtr;
}

void PrintMatrix(int[,] mtr)
{
    for (int i=0; i<mtr.GetLength(0); i++, Console.WriteLine())
        for (int j=0; j<mtr.GetLength(1); j++)
            Console.Write($"{mtr[i,j]} ");
}

int m = ReadInt("ВВедите m: ");
int n = ReadInt("ВВедите n: ");
int[,] mtr = CreateMatrix(m,n);
Console.WriteLine("Выводим матрицу");
PrintMatrix(mtr);
Otvet(mtr);