using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_ArrayList
{
    public class lineararraylist
    {
        /// <summary>
        /// numbers currently stored
        /// </summary>
        private int count;

        /// <summary>
        /// an array to hold values entred
        /// </summary>
        private int[] values;

        public int Count
        {
            get
            {
                return count;
            }
        }


        /// <summary>
        /// constructor creates list with
        /// maximum capacity 10
        /// </summary>
        public lineararraylist()
        {
            count = 0;
            values = new int[5];
        }

        //public lineararraylist(int value)
        //{
        //    count = 0;
        //    //values = new int[value];
        //}

        /// <summary>
        /// returns true if the list is empty
        /// false if its not
        /// </summary>       
        public bool isEmpty()
        {
            if (count == 0)
                return true; 
            else
                return false;
        }

        /// <summary>
        /// //returns true if the list id full
        /// </summary>       
        public bool isFull()
        {
            if (count == 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        ///  //clears the list
        /// </summary>
        public void destroy()
        {
            count = 0;
        }

        /// <summary>
        /// if theres no space in at the end of the array it will show an error message
        /// if there is space it will add the value to the next avalible space
        /// </summary>        
        public void addLast(int value)
        {
            if (count >= values.Length)
            {
                throw new Exception("no room at inn");
            }
            else
            {
                values[count++] = value;
            }
        }


        /// <summary>
        /// if there is no space at the beginnign of the array then show an error message
        /// otherwise add the value into the first index of the array
        /// </summary>
      
        public void addFirst(int value)
        {
            //if (isFull())
            //{
            //    throw new Exception("Full");
            //}
            {
               
                for (int i = count; i > 0; i--)
                {
                    values[i] = values[i - 1] ;

                }
                values[0] = value;
                count++;

            }
        }

        /// <summary>
        /// if there is no value in the first index, returns error
        /// if there is a value it removes it
        /// </summary>
    
        public int removeFirst()
        {
            int value;
            if (isEmpty())
            {
                throw new Exception("empty");
            }

            else
            {
                value = values[0];
                for (int i = 1; i < count; i++)
                {
                    values[i - 1] = values[i];
                }
            }
            values[count - 1] = 0;
            count--;
            return value;
        }
        /// <summary>
        /// removes the last value of the array
        /// </summary>
      
        public int removeLast()

        {
            int value;
            value = values[count - 1];
            count--;



            return value;
        }




        /// <summary>
        /// this is a linear search that returns the index with a value in it
        /// if it cannot find a value then it returns -1
        /// </summary>
       
        
        public int search(int value)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == value)
                {
                    return count;
                }
            }
            return -1;
        }

    


        public void displayUI()
        {
            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine(values[i]);
            }
        }

        /// <summary>
        /// a selection sort that finds the smallest value and 
        /// puts it into the first index then takes the next 
        /// smallest and so on untill the list is sorted from smallest to 
        /// highest
        /// </summary>
        public void selectionsort()
        {
            int N = values.Length;

            for (int i = 0; i < N; i++)
            {
                int small = values[i];
                int pos = i;

                for (int j = i + 1; j < N; j++)
                {
                    if (values[j] < small)
                    {
                        pos = j;
                    }
                }

                int temp = values[pos];
                values[pos] = values[i];
                values[i] = temp;

            }

        }
    }
}
