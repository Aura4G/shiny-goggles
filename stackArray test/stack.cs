using System;

namespace stackArray_test
{
    public class stack
    {
        public int[] stackArray = new int[20];
        public int pointerValue = 0;
        int returnValue;

        public int pop()
        {
            if (pointerValue == 0)
            {
                return -1;
            }
            else
            {
                pointerValue--;
                returnValue = stackArray[pointerValue];
                return returnValue;
            }
        }

        public bool push(int value)
        {
            if (pointerValue == stackArray.Length)
            {
                return false;
            }
            else
            {
                stackArray[pointerValue] = value;
                pointerValue++;
                return true;
            }
        }

        public void displayArray()
        {
            int counter = 0;
            while (counter < pointerValue)
            {
                Console.Write(stackArray[counter] + ", ");
                counter++;
            }
            Console.WriteLine();
        }
    }
}
