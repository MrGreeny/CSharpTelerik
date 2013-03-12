using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generic
{
    public class GenericList<T>
        where T : IComparable
    {
        private T[] array;
        private int currentElement = 0;
        private int size;

        //General purpouse constructor
        public GenericList(int size)
        {
            array = new T[size];
            this.size = size;
        }

        //Adds an element at the end of the aray
        public void Add(T element)
        {

            if (currentElement >= array.Length)
            {
                this.Grow();
            }

            array[currentElement] = element;
            currentElement++;
        }

        //auto-grow functionality
        private void Grow()
        {
            //Creating a copy of the array
            T[] arrayCopy = new T[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                arrayCopy[i] = array[i];
            }

            //Making the array double in size
            array = new T[arrayCopy.Length * 2];

            //Copying the values from the ccopy array
            //to the new double sized one
            for (int i = 0; i < arrayCopy.Length; i++)
            {
                array[i] = arrayCopy[i];
            }
        }

        //Removes the element and trims the array
        public void Remove(int index)
        {
            //checking if index is valid
            if (index >= 0 && index <= array.Length)
            {
                //creating a new array to copy the current one into
                T[] copyArray = new T[array.Length];
                //Copying the first half of the aray
                //to the index
                for (int i = 0; i < index; i++)
                {
                    copyArray[i] = array[i];
                }
                //Copying the elements after the index
                for (int i = index+1; i < array.Length; i++)
                {
                    copyArray[i-1] = array[i];
                }
                //Changing the current array
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = copyArray[i];
                }
                currentElement--;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }            
        }

        public void Insert(T element, int index)
        {
            //checking if index is valid
            if (index >= 0 && index <= array.Length)
            {
                //doubles the array if the count of elements after the
                //inserting exedes the size
                if (currentElement + 1 >= array.Length)
                {
                    this.Grow();
                }

                //Creates new array
                T[] copyArray = new T[array.Length];
                //Copying the values preceding the index
                for (int i = 0; i < index; i++)
                {
                    copyArray[i] = array[i];
                }
                //inserting the wanted element
                copyArray[index] = element;

                //Copying the rest of the array
                for (int i = index+1; i < array.Length; i++)
                {
                    copyArray[i] = array[i];
                }

                //Changing the result array
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = copyArray[i];
                }

                //Keeping tabs on the current element
                currentElement++;
                
            }
            else
            {
                throw new IndexOutOfRangeException();
            }  
        }

        public void Clear()
        {
            //Removes every existing element
            for (int i = currentElement; i >= 0; i--)
            {
                this.Remove(i);
            }
            currentElement = 0;
        }

        //indexer
        public T this[int index]
        {
            get
            {
                if (index >= 0 && index <= size)
                {
                    return array[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                //Can only change existing elements
                if (index >= 0 && index <= currentElement)
                {
                    array[index] = value;

                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        public T Max<T>()
        {
            //keeps the index of the maximal element
            int indexOfMax = 0;

            //runs through all existing elements
            for (int i = 0; i < currentElement-1; i++)
            {
                //changes the index of the minimal element if its smaller
                if ((array[indexOfMax].CompareTo(array[i])) < 0)
                {
                    indexOfMax = i;
                }
            }
            //Converts the element to type T and returns it
            return (T) System.Convert.ChangeType( array[indexOfMax], Type.GetTypeCode(typeof(T)));
        }

        public T Min<T>()
        {
            int indexOfMin = 0;

            for (int i = 0; i < currentElement-1; i++)
            {
                if ((array[indexOfMin].CompareTo(array[i])) >= 0)
                {
                    indexOfMin = i;
                }
            }

            return (T)System.Convert.ChangeType(array[indexOfMin], Type.GetTypeCode(typeof(T)));
        }



        public override string ToString()
        {
            string result = "[";
            for (int i = 0; i < array.Length; i++)
            {
                result+= string.Format("{0},", array[i]);
            }
            result+="]";
            return result;
        }

    }
}
