using System;

namespace Find_Missing_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            // איך לא חשבתי על זה במקום לא יודע 

            int[] numbers = new int[1000];
            int min = 0, max;
            for (int i = 2000, y = 0; y < 1000; i--, y++)
            {
                numbers[y] = i;
                min = numbers[y];
            }
            Console.WriteLine("Number Switched: " + numbers[325]);
            numbers[325] = -1;
            max = numbers[0];
            Console.WriteLine("Number Switched from function: " + FindMissingNumber(numbers, min, max));
        }
        static int FindMissingNumber(int[] numbers, int min, int max)
        {
            int sum = 0;
            foreach(int num in numbers)
            {
                int current = num == -1 ? 0 : num;
                sum += current;
            }
            Console.WriteLine("total sum " + sum );
            return (max + 1) * max / 2 - (min + 1) * min / 2 + min - sum;
        }
    } 
}
