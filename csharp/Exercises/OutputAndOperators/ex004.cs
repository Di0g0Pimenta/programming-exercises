//Instructions: Write a program that displays the integer part of a number entered by the user on the screen.

namespace Exercises.OutputAndOperators
{
    public static class Ex004
    {
        public static void Run()
        {
            float r;
            Console.WriteLine("Enter a real number ");
            r = Convert.ToSingle(Console.ReadLine()); //Please note that in a Portuguese Windows console, the decimal separator is a comma.
            Console.WriteLine("The integer part of {0} is {1}",r,(int)r);
        }
    }
}