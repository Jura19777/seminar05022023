//Написать программу, упорядочивания по убыванию элементы каждой строки двумерного массива

int ReadInt(string str)
{
    Console.Write(str);
    return int.Parse(Console.ReadLine()!);
}

int[,] NewMatrix(int[,] mtr)
{   
    for (int i=0; i<mtr.GetLength(0); i++)
            for (int j=0; j<mtr.GetLength(1)-1; j++)
            {
                for (int k = 0; k < mtr.GetLength(1) - 1; k++)
                {
                if (mtr[i, k] < mtr[i, k + 1])
                    {
                    int temp = mtr[i, k + 1];
                    mtr[i, k + 1] = mtr[i, k];
                    mtr[i, k] = temp;
                    }
                }
            }
    return mtr;
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
Console.WriteLine("Выводим измененую матрицу");
NewMatrix(mtr);
PrintMatrix(mtr);