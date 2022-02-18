using System;

namespace TaskNET012
{
    /// <summary>
    /// Matrix class is simply One-Dimension array who can change
    /// to Two-Dimensional array with some Condition and Methods
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class Matrix<T> 
    {
        public EventHandler<MatrixEventArgs> OnItemChange { get; set; }
        protected  T[] _matrix;
        protected int _rowNumber;
        protected int _colNumber;

        /// <summary>
        /// Matrix Generic"T" Constructor
        /// There have Exception and there have some Condition
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="cols"></param>
        /// <exception cref="ArgumentException"></exception>
        public Matrix(int rows, int cols)
        {
            if (rows <= -1 && rows < 0 || cols <= -1 && cols < 0)
            {
                throw new ArgumentException();
            }
            else
            {
                this.RowNumber = rows;
                this.ColsNumber = cols;
                this._matrix = new T[RowNumber];
            }
        }
        /// <summary>
        /// Property _colNumber
        /// </summary>
        protected int ColsNumber
        {
            get { return _colNumber; }
            set { _colNumber = value; }
        }
        /// <summary>
        /// Property _rowNumber
        /// </summary>
        protected int RowNumber
        {
            get { return _rowNumber; }
            set { _rowNumber = value; }
        }
        /// <summary>
        /// indexers allow instances of a class or struct to be indexed just like arrays.
        /// </summary>
        /// <value value="_matrix[GetIndex(i, j)]"></value>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        /// <exception cref="IndexOutOfRangeException"></exception>
        public virtual T this[int i, int j]
        {
            get
            {                
                return _matrix[GetIndex(i, j)];
            }
            set
            {
                if (i > _rowNumber || j > _colNumber || i < 0 || j < 0 )
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
        /// GetIndex is Method who split two parameter
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public abstract int GetIndex(int i, int j);
     
    }
}
