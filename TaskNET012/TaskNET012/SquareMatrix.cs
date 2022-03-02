using System;
using System.Collections.Generic;
using System.Text;

namespace TaskNET012
{
    /// <summary>
    /// Generic Type SquareMatrix
    /// Inheritence from Matrix Class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SquareMatrix<T> : Matrix<T>
    {
        private int _squareSize { get; set; }
        /// <summary>
        /// SquareMatrix Constructor with Condition for Resize
        /// </summary>
        /// <param name="matrixSize"></param>
        public SquareMatrix(int matrixSize) : base(matrixSize,matrixSize)
        {
            matrixSize = RowNumber * ColsNumber;
            base._matrix = new T[matrixSize];
        }
        /// <summary>
        /// This Indexer is override from Matrix CLass
        /// </summary>
        /// <value value="_matrix[GetIndex(i, j)]"></value>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        /// <exception cref="IndexOutOfRangeException"></exception>
        public override T this[int i, int j]
        {
            get { return _matrix[GetIndex(i, j)]; }
            set
            {
                if (i > _rowNumber || j > _colNumber || i < 0 || j < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                else if (_matrix[GetIndex(i, j)].Equals(value))
                {
                    Console.WriteLine("Not Generate Event");
                }
                else
                {
                OnItemChange?.Invoke(this, new MatrixEventArgs(i, j, value));
                _matrix[GetIndex(i, j)] = value;
                }
            }
        }
        /// <summary>
        /// In SquareMatrix Class The GetIndex Method have another override condition 
        /// We need this Algorithm to get a Element from Square Form
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
            public override int GetIndex(int i, int j) => (i * RowNumber) + j;
    }
}
