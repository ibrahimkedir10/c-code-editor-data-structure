// See https://aka.ms/new-console-template for more information

using System;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)

        {
            
            // interface 
           //  MyClass myObject = new MyClass();

        // Call methods from implemented interfaces
         //   myObject.Study();
          //  myObject.Teach();
            
            // over riding interface 
            //IoverrideClass myObject2  = new IoverrideClass();
          //  myObject2.Study();
             
             


        // overirding 
        //Shape shape = new Circle();    // circle object is what will be called
        // shape.Draw();  // Calls the overridden method in the Circle class


        // overloading
        //Num addnums = new Num();
         //int result = addnums.Add(4,5);
         //Console.WriteLine(result);


         
         
        // ARRAYS 
        // Create an instance of ArrayClass
        ArrayClass myArray = new ArrayClass();

        // Add elements to the array
        for (int i = 1; i <= 15; i++)
        {
            myArray.AddArray(i);
        }

        // Display the elements in the array
        Console.WriteLine("Array Elements:");
        for (int i = 0; i < myArray.Size; i++)
        {
            Console.Write(myArray[i] + " ");
        }

        Console.ReadLine(); // To keep the console window open
            
        

        }
        static int fibo(int n)
        {
            if (n < 2)
            {
                return n;
            }
            return fibo(n - 1) + fibo(n - 2);
        }



        static int Search(int[] arr, int target, int start, int end)
        {
            while (start <= end)
            {
                int mid = (start + end) / 2;

                if (arr[mid] > target)
                {
                    end = mid - 1;
                }
                else if (arr[mid] < target)
                {
                    start = mid + 1;
                }
                else
                {
                    return mid;
                }
            }
            return -1;
        }

        static int Factorial(int number)
        {
            if (number <= 1)
            {
                return number;
            }
            return number * Factorial(number - 1);

        }

        static int sum = 0;

        static int Reverse(int num)
        {
            if (num == 0)
            {
                return sum;
            }

            int rem = num % 10;
            sum = sum * 10 + rem;
            return Reverse(num / 10);
        }

      
    }

   
}


