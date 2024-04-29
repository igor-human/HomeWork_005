using System;
using System.Runtime.InteropServices;
using System.Text;

class MyMatrix
    {
        private int[,] matrix;

        public MyMatrix(int rows, int cols)
        {
            matrix = new int[rows, cols];
        }

        public void SetValue(int row, int col, int value)
        {
            matrix[row, col] = value;
        }

        public void Display()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public void Resize(int newRows, int newCols)
        {
            int[,] newMatrix = new int[newRows, newCols];

            // Копіювання старих даних до нової матриці
            for (int i = 0; i < Math.Min(newRows, matrix.GetLength(0)); i++)
            {
                for (int j = 0; j < Math.Min(newCols, matrix.GetLength(1)); j++)
                {
                    newMatrix[i, j] = matrix[i, j];
                }
            }

            matrix = newMatrix; // Оновлення посилання на матрицю
        }

    }
class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        MyMatrix myMatrix = new MyMatrix(3, 3);

        int value = 1;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                myMatrix.SetValue(i, j, value);
                value++;
            }
        }
        Console.WriteLine("Початкова матриця 3x3:");
        myMatrix.Display(); // Виведення початкової матриці

        // Змінення розміру матриці до 4x5
        myMatrix.Resize(4, 5);
        //І внесення зміни
        myMatrix.SetValue(3, 3, 10);

        Console.WriteLine("\nЗмінена матриця 4x5:");
        myMatrix.Display(); // Виведення зміненої матриці
    }
}

