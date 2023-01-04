using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace LotOfTasks
{
    class Matrix
    {
        int[,] content;
        int numberOfColumns;
        int numberOfRows;

        public static Matrix operator *(Matrix m1, Matrix m2)
        {
            return m1.Multiplying(m2);
        }
        public Matrix(int numberOfColumns, int numberOfRows)
        {
            this.numberOfColumns = numberOfColumns;
            this.numberOfRows = numberOfRows;
            content = new int[numberOfColumns, numberOfRows];
        }

        public Matrix Multiplying(Matrix matrixToMultipleBy)
        {
            if (this.numberOfColumns != matrixToMultipleBy.numberOfRows)
                throw new ArithmeticException("Dwie macierze można pomnożyć tylko wtedy gdy liczba kolumn macierzy A jest równa liczbie wierszy macierzy B");
            Matrix result = new Matrix(matrixToMultipleBy.numberOfColumns, this.numberOfRows);
            
            for (int column = 0; column < result.numberOfColumns; column++)
            {
                for (int row = 0; row < result.numberOfRows; row++)
                {
                    result.content[column, row] = 0;
                    for (int i = 0; i < this.numberOfColumns; i++)
                    {
                        result.content[column,row] += this.content[i,row] * matrixToMultipleBy.content[column,i];
                    }
                }
            }
            return result;
        }
    
        public void SetRandomContent()
        {
            Random random = new Random();
            for (int y = 0; y < this.numberOfRows; y++)
            {
                for (int x = 0; x < numberOfColumns; x++)
                {
                    this.content[x, y] = random.Next(1, 10)%3 + 1;
                }
            }
        }
        public void ShowMatrix()
        {
            for (int y = 0; y < this.numberOfRows; y++)
            {
                for (int x = 0; x < numberOfColumns; x++)
                {
                    Console.Write(this.content[x,y] + " ");
                }
                Console.WriteLine();
            }
      
        }
        public override string ToString()
        {
            string showMatrix = "";
            for (int y = 0; y < this.numberOfRows; y++)
            {
                for (int x = 0; x < numberOfColumns; x++)
                {
                    showMatrix += this.content[x, y] + " ";
                }
                showMatrix += "\n";
            }
            return showMatrix;
        }
    }
}
