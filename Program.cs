using System;

namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = 17;
            int B = 4;
            int quotient = A / B;
            int remainder = A % B;


            Console.WriteLine($"{A} / {B} is {quotient} remainder {remainder}");

            {

                Console.WriteLine("What is the radius of your circle?");

                var R = double.Parse(Console.ReadLine());
                var AreaOfCircle = Math.PI * R * R;

                Console.WriteLine(value: $"The area of a circle with radius of {R} is {AreaOfCircle}");
            }



            }
    }
}
