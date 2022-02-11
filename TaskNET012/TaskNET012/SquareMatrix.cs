using System;
using System.Collections.Generic;
using System.Text;

namespace TaskNET012
{
    public class SquareMatrix : Matrix
    {
        public SquareMatrix(int matrixSize) : base(matrixSize)
        {
        }

        protected override int GetElementAtPosition(int row, int col)
        {
            return matrix[GetIndex(row, col)];
        }
        protected override int GetIndex(int row, int col)
        {
            return (row * this.MatrixSize) + col;
        }
    }
}
