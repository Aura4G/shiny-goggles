using System;

namespace stackArray_test
{
    class main
    {
        static void Main(string[] args)
        {
            stack mathsStack = new stack();
            string response;
            bool running = true;
            while (running)
            {
                int removed = 0;
                int total = 0;
                Console.WriteLine("1) Maths-Stack  2) quit");
                response = Console.ReadLine();
                if (response == "1")
                {
                    bool returnValue = true;
                    while (returnValue)
                    {
                        Console.Write("Enter number: ");
                        string response2 = Console.ReadLine();
                        int newNum = Convert.ToInt32(response2);
                        returnValue = mathsStack.push(newNum);
                        if (returnValue == false)
                        {
                            Console.WriteLine("Stack full");
                        }
                    }
                    while (mathsStack.pointerValue > 0 && removed < 20)
                    {
                        total = total + mathsStack.stackArray[mathsStack.pointerValue -1];
                        mathsStack.pop();
                        Console.WriteLine(total);
                        removed++;
                    }
                }
                if (response == "2")
                {
                    running = false;
                }
                else
                {

                }
            }
        }
    }
}
