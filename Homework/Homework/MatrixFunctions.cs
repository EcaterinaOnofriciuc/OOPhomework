using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class MatrixFunctions
    {

        public void GetSummOfDiagonalsElements(int[,] matrixOfIntegers)
        {
            var hasDiagonals = CheckIfMatrixHasDiagonals(matrixOfIntegers);
            if (hasDiagonals)
            {
                var length = matrixOfIntegers.GetLength(0);
                var firstSum = 0;
                var secondSum = 0;
                for (var i = 0; i < length; i++)
                {
                    firstSum += matrixOfIntegers[i, i];
                    secondSum += matrixOfIntegers[i, length - i - 1];
                }
                Console.WriteLine($"First Diagonal: {firstSum}");
                Console.WriteLine($"Second Diagonal: {secondSum}");
            }

        }

        private bool CheckIfMatrixHasDiagonals(int[,] matrixOfIntegers)
        {
            if (matrixOfIntegers.GetLength(0) != matrixOfIntegers.GetLength(1))
            {
                Console.WriteLine("This matrix doesn't have diagonals");
                return false;
            }
            return true;
        }
    }
}
