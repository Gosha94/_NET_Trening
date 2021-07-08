using System;

namespace FunWithMatrix
{
    public struct User
    {
        public string Name { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 3];

            int rank = GetMatrixRank(matrix);

            if (IsMatrixCubic(matrix))
            {
                matrix = FillMatrixRandomNumbers(matrix);
            }
            
            var transposedArr = TransposeMatrix(matrix);            
        }

        private static int[,] TransposeMatrix(int[,] transposedMatrix)
        {
            for (int i = 0; i < transposedMatrix.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    int tempCellData = transposedMatrix[i, j];
                    transposedMatrix[i, j] = transposedMatrix[j, i];
                    transposedMatrix[j, i] = tempCellData;
                }
            }
            
            return transposedMatrix;
        }

        // Тесты
        // Дважды транспонированная матрица А равна исходной матрице А
        // Транспонированная сумма матриц равна сумме транспонированных матриц
        // Транспонированное произведение матриц равно произведению транспонированных матриц, взятых в обратном порядке

        /// <summary>
        /// Метод получает число измерений массива
        /// </summary>
        /// <param name="matrixForCheck"></param>
        /// <returns></returns>
        private static int GetMatrixRank(int[,] matrixForCheck)
        {
            return matrixForCheck.Rank;
        }

        private static bool IsMatrixCubic(int[,] matrixForCheck)
        {
            int firstDimension = matrixForCheck.GetUpperBound(0);
            int secondDimension = matrixForCheck.GetUpperBound(1);            

            return (firstDimension == secondDimension) ? true : false;
        }

        private static int[,] FillMatrixRandomNumbers(int[,] matrixForFill)
        {
            Random rand = new Random();            

            for (int i = 0; i < matrixForFill.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < matrixForFill.GetUpperBound(1) + 1; j++)
                {
                    matrixForFill[i, j] = rand.Next(0,9);
                }
            }
            return matrixForFill;
        }
    }
}