using static System.Formats.Asn1.AsnWriter;
using System.Reflection.Metadata;
using System.Threading;
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.Intrinsics.X86;
using System;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Operator Exercise 1

            //Console.ReadLine();

            var a = 17;
            var b = 4;
            var quotient = a / b;
            var remainder = a % b;

            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");

            Console.WriteLine("Please enter the radius of your circle:");
            var userInput = Console.ReadLine();

            var radius = double.Parse(userInput);

            Console.Write(AreaOfCircle(radius));

            //Operator Exercise 2
            //Create a method that will Calculate the area of a circle based on its radius - you can name the method AreaOfCircle.
            //This method will use this formula Math.PI* Math.Pow(radius, 2) and return the area of type double
            //The method will also accept radius as a parameter
            //Allow a user to input a value for radius in the console using the following code:

            //Define a method - which performs some functionality.
            //that can be used over and over again.
        }
          
            public static double AreaOfCircle(double radius)

            {
                //This is the scope of the method
                var area = Math.PI * Math.Pow(radius, 2);

                return area;
            }
        }

    }


