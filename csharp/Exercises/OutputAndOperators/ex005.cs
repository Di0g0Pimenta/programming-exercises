// Statement: Write a program that displays the numbers 4.68805; 4.8; 5.9964; and 5 rounded to 
// three different lines, with the first line showing all numbers rounded 
// to three decimal places, the second to two, and the third to one decimal place.

namespace Exercises.OutputAndOperators
{
    public static class Ex005
    {
        public static void Run()
        {
            Console.WriteLine("{0:F3}\t{1:F3}\t{2:F3}\t{3:F3}",4.68805,4.8,5.9964,5);
            Console.WriteLine("{0:F2}\t{1:F2}\t{2:F2}\t{3:F2}",4.68805,4.8,5.9964,5);
            Console.WriteLine("{0:F1}\t{1:F1}\t{2:F1}\t{3:F1}",4.68805,4.8,5.9964,5);
        }
    }
}