using System;
using System.Linq;

namespace Array_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1)
            string[] myArray = new string[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter {0} element: ", i);
                myArray[i] = Console.ReadLine();
            }
            Console.Write("Elements in array: ");
            foreach (string item in myArray)
            {
                Console.Write(" {0}", item);
            }
            */
            /* 2)
            Console.Write("Input number of elements to store in array: ");
            int.TryParse(Console.ReadLine(), out int number);
            int[] myArray = new int[number];
            for (int i = 0; i < number; i++)
            {
                Console.Write("Enter {0} element: ", i);
                int.TryParse(Console.ReadLine(), out myArray[i]);
            }
            Console.Write("Elements stored in array: ");
            foreach (int item in myArray)
            {
                Console.Write(item + " ");
            }
            Array.Reverse(myArray);
            Console.Write("\nElements stored in reversed array: ");
            foreach (int item in myArray)
            {
                Console.Write(item + " ");
            }
            */
            /* 3)
            Console.Write("Input number of elements to store in array: ");
            int.TryParse(Console.ReadLine(), out int number);
            int[] myArray = new int[number];
            for (int i = 0; i < number; i++)
            {
                Console.Write("Enter {0} element: ", i);
                int.TryParse(Console.ReadLine(), out myArray[i]);
            }
            int sum = 0;
            foreach (int item in myArray)
            {
                sum += item;
            }
            Console.WriteLine("Sum of elements in array: {0}.", sum);
            */
            /* 4)
            Console.Write("Input number of elements to store in array: ");
            int.TryParse(Console.ReadLine(), out int number);
            int[] myArray = new int[number];
            for (int i = 0; i < number; i++)
            {
                Console.Write("Enter {0} element: ", i);
                int.TryParse(Console.ReadLine(), out myArray[i]);
            }
            int[] myNewArray = new int[number];
            for (int i = 0; i < number; i++)
            {
                myNewArray[i] = myArray[i];
            }
            Console.Write("Elements stored in array: ");
            foreach (int item in myArray)
            {
                Console.Write(item + " ");
            }
            Console.Write("\nElements stored in new array: ");
            foreach (int item in myNewArray)
            {
                Console.Write(item + " ");
            }
            */
            /* 5)
            Console.Write("Input number of elements to store in array: ");
            int.TryParse(Console.ReadLine(), out int number);
            int[] myArray = new int[number];
            for (int i = 0; i < number; i++)
            {
                Console.Write("Enter {0} element: ", i);
                int.TryParse(Console.ReadLine(), out myArray[i]);
            }
            int[] myNewArray = new int[number];
            int count = 0;
            for (int i = 0; i < number; i++)
            {
                if (!myNewArray.Contains(myArray[i]))
                { 
                    myNewArray[i] = myArray[i];
                }
                else count++;
            }
            Console.WriteLine(count);
            */
            /* 6)
            Console.Write("Input number of elements to store in array: ");
            int.TryParse(Console.ReadLine(), out int number);
            int[] myArray = new int[number];
            for (int i = 0; i < number; i++)
            {
                Console.Write("Enter {0} element: ", i);
                int.TryParse(Console.ReadLine(), out myArray[i]);
            }
            int[] myNewArray = new int[number];
            for (int i = 0; i < number; i++)
            {
                if (!myNewArray.Contains(myArray[i]))
                {
                    myNewArray[i] = myArray[i];
                }
            }
            
            Console.Write("Unique elements found in the array are: ");
            for (int i = 0; i < myNewArray.Length; i++)
            {
                if (myNewArray[i] != 0)
                {
                    Console.Write(myNewArray[i] + " ");
                }
            }
            */
            /* 7)
            Console.Write("Input number of elements to store in array: ");
            int.TryParse(Console.ReadLine(), out int number);
            int[] myArray = new int[number];
            for (int i = 0; i < number; i++)
            {
                Console.Write("Enter {0} element: ", i);
                int.TryParse(Console.ReadLine(), out myArray[i]);
            }
            Console.Write("Input number of elements to store in array: ");
            int.TryParse(Console.ReadLine(), out int number1);
            int[] mySecondArray = new int[number1];
            for (int i = 0; i < number1; i++)
            {
                Console.Write("Enter {0} element: ", i);
                int.TryParse(Console.ReadLine(), out mySecondArray[i]);
            }
            Array.Resize(ref myArray, myArray.Length + mySecondArray.Length);
            Array.Copy(mySecondArray,0,myArray,number,mySecondArray.Length);
            Array.Sort(myArray);
            Console.Write("Elements stored in array: ");
            foreach (int item in myArray)
            {
                Console.Write(item + " ");
            }
            */
        }
    }
}
