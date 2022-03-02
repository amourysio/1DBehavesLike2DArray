using System;
using System.Collections.Generic;
using System.Text;

namespace TaskNET012
{
    /// <summary>
    /// Evenet for Matrix Condition
    /// </summary>
    public class MatrixEventArgs : EventArgs
    {
        public int _rowI { get; private set; }
        public int _colI { get; private set;}
        public object _value { get; private set; }
        /// <summary>
        /// MatrixEventArgs Constructor
        /// There Get The same varieble like Matrix Class
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <param name="value"></param>
        public MatrixEventArgs(int i, int j, object value)
        {
            this._value = value;
            this._rowI = i;
            this._colI = j;
        }

    }
}
