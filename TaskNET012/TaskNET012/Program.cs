using System;

namespace TaskNET012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SquareMatrix<int> square = new SquareMatrix<int>(3);
            //square.OnItemChange += MyMethod;
            
            //square[1, 2] = 1;
            //square[1, 2] = 1;
            
            DiagonalMatrix<int> diagonal = new DiagonalMatrix<int>(3);
            diagonal.OnItemChange +=MyMethod;
            diagonal[0, 0] = 5;
            diagonal[0, 0] = 5;
            Console.WriteLine(diagonal[0, 0]);



        }
        public static void MyMethod(object arg, MatrixEventArgs matrixEventArgs)
        {
            Console.WriteLine(matrixEventArgs._colI.ToString(),matrixEventArgs._rowI.ToString(),matrixEventArgs._value.ToString());
            Console.WriteLine("Item Change");
        }


    }
}
