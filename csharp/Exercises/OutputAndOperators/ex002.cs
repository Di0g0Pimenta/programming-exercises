//Instructions: Write a program that displays the result of the expression 5/2 on the screen. Analyze the result.

namespace Exercises.OutputAndOperators
{
    public static class Ex002
    {
        public static void Run()
        {
            Console.WriteLine(5/2); // integer division because both the numerator and the denominator are integers
            Console.WriteLine(5/2.0); // real division because the denominator is a real number
            Console.WriteLine((float)5/2); // This is a real division because the numerator is a real number; a type cast (type conversion) was performed.
        }
    }
}