using System;

namespace TaskNET012
{
    // Generic
    public abstract class Matrix
    {

        private int[] _matrix;
        private int _matrixSize;
        
        public Matrix(int matrixSze)
        {
            this.MatrixSize=matrixSze;
            this._matrix = new int[MatrixSize * MatrixSize];
        }
       
        // TODO: make it private/protected
        public int[] matrix
        {
            get { return _matrix; }
           private set { _matrix = value; }
        }
        protected int MatrixSize
        {
            get { return _matrixSize; }
            set { _matrixSize = value; }
        }
        protected void SetElementAtPosition(int row,int col, int value)
        {
           
            if(GetIndex(row, col) == value)
            {
                throw new ArgumentException("Value is Equal");
            }
            else
            {
                matrix[GetIndex(row, col)] = value;
            }
         }
        protected virtual int GetElementAtPosition(int row,int col)
        {
            return matrix[GetIndex(row, col)];
        }
        protected abstract int GetIndex(int row, int col);

        // Add indexer


    }
}
