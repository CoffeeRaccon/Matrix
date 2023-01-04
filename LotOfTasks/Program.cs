using System;

namespace LotOfTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix1 = new Matrix(2, 2);
            Matrix matrix2 = new Matrix(3, 3);
            matrix1.SetRandomContent();
            matrix2.SetRandomContent();
            matrix1.ShowMatrix();
            Console.WriteLine();
            matrix2.ShowMatrix();
            Console.WriteLine("---------------------------------");
            matrix1.Multiplying(matrix2).ShowMatrix();
            Matrix m3 = matrix1 * matrix2;
            Console.WriteLine("---------------------------------");
            Console.WriteLine(m3);
        }
    }
}
