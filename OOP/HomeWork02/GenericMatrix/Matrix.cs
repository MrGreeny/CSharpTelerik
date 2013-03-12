using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generic
{
    
    public class Matrix<T>
        where T : struct, 
          IComparable,
          IComparable<T>,
          IConvertible,
          IEquatable<T>,
          IFormattable
    {
        //private int columns;
        //private int rows;
        private T[,] matrixArray;

        public Matrix(int rows, int columns)
        {
            matrixArray = new T[rows, columns];
        }

        //Indexer
        public T this[int row, int col]
        {
            get
            {
                //Checks if the indexer is within range 
                if ( (row >=0 && row < matrixArray.GetLength(0)) && 
                    (col>=0 && col < matrixArray.GetLength(1)) )
                {
                    return matrixArray[row, col];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                //Checks if the indexer is within range
                if ((row >= 0 && row < matrixArray.GetLength(0)) &&
                    (col >= 0 && col < matrixArray.GetLength(1)))
                {
                    matrixArray[row, col] = value ;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }//End of the indexer

        //A GetLenght method similar to GetLength for arrays
        public int GetLength(int depth)
        {
            //Works only for one and two dimentional arrays
            if (depth ==0)
            {
                return matrixArray.GetLength(0);
            }
            else if (depth == 1)
            {
                return matrixArray.GetLength(1);
            }
            else
            {
                return -1;
            }
        }//end GetLength


        //Defining the operator +
        public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2)
        {
            //The assignment states, that the matrices should be with equal dimentions
            if (m1.GetLength(0) == m2.GetLength(0) && m1.GetLength(1) == m2.GetLength(1))
            {
                Matrix<T> result = new Matrix<T>(m1.GetLength(0), m1.GetLength(1));

                //adds every element of one matrix with the coresponding element from the other matrix
                for (int i = 0; i < m1.GetLength(0); i++)
                {
                    for (int j = 0; j < m1.GetLength(1); j++)
                    {
                        //It's dynamic, because ot the generic type
                        result[i, j] = (dynamic)m1[i, j] + m2[i, j];
                    }

                }
                return result;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }//end operator+ 

        //Same like the operator +
        public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.GetLength(0) == m2.GetLength(0) && m1.GetLength(1) == m2.GetLength(1))
            {
                Matrix<T> result = new Matrix<T>(m1.GetLength(0), m1.GetLength(1));

                for (int i = 0; i < m1.GetLength(0); i++)
                {
                    for (int j = 0; j < m1.GetLength(1); j++)
                    {
                        result[i, j] = (dynamic)m1[i, j] - m2[i, j];
                    }

                }
                return result; 
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }//end operator -

        //Operator multiplication
        public static Matrix<T> operator *(Matrix<T> m1, Matrix<T> m2)
        {
            //Multiplication works only if the columns of the first matrix
            //are equal to the rows of the second
            if (m1.GetLength(1) == m2.GetLength(0) )
            {
                //using m,n, and p to make it easyer to read.
                int n = m1.GetLength(0);
                int m = m1.GetLength(1);
                int p = m2.GetLength(1);

                T sum = (dynamic) 0;

                Matrix<T> result = new Matrix<T>(m1.GetLength(0), m2.GetLength(1));

                //For every element of the matrix 
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < p; j++)
                    {
                        for (int k = 0; k < m; k++)
                        {
                            //The element is calculated 
                            sum += (dynamic) m1[i, k] * m2[k, j];
                        }
                        result[i, j] = sum;
                        sum = (dynamic) 0;
                    }
                    
                }
                return result;

            }
            else
            {
                throw new IndexOutOfRangeException();

            }
        }//end operator * (multiplication)

        
        public static bool operator true(Matrix<T> m)
        {
            //tries to find a non-zero element in the matrix
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    //if found returns true - the matrix isn't the zero matrix
                    if (m[i,j] != (dynamic) 0 )
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator false(Matrix<T> m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    if (m[i, j] != (dynamic)0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        //Simple method for printing the matrix.
        public void PrintMatrix()
        {
            for (int i = 0; i < matrixArray.GetLength(0); i++)
            {
                for (int j = 0; j < matrixArray.GetLength(1); j++)
                {
                    Console.Write("{0}  ", matrixArray[i,j]);  
                    
                }
                Console.WriteLine();
                
            }
        }
    }
}
