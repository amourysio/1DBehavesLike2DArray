using System;
using System.Collections.Generic;
using System.Text;

namespace TaskNET012
{
    /// <summary>
    /// Generic Type DiagonalMatrix
    /// Inheritence from Matrix Class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class DiagonalMatrix<T> : Matrix<T>
    {
        /// <summary>
        /// DiagonalMatrix Constructor with Condition for Resize
        /// </summary>
        /// <param name="matrixSize"></param>
        public DiagonalMatrix(int matrixSize) : base(matrixSize, matrixSize)
        { 
            base._matrix = new T[matrixSize];
        }
        /// <summary>
        /// This Indexer is override from Matrix CLass
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        /// <exception cref="IndexOutOfRangeException"></exception>
        public override T this[int i, int j]
        {
            get
            {
                if(j != i)
                {
                   
                    return default(T);
                }
               
                return base._matrix[GetIndex(i, j)];
            }
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
        ///  In DiagonalMatrix Class The GetIndex Method have another override condition
        /// We need this simply return index to get a Element from Diagonal Form
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public override int GetIndex(int i, int j)
        {
            
            return i;
        }
    }
    // 123456789
    // 1 2 3 
    // 4 5 6
    // 7 8 9

    // 1 0 0  (0,0)
    // 0 2 0  (1,1) (1,2)
    // 0 0 3  (2,2)

    // 1(0), 2(1), 3(2)

    // if(i != j) retun 0
    // else return matrix[i]
}
