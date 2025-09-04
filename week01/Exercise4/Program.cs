using System;

class Program
{
    static void Main(string[] args)
    {

        // a numbers list 
        List<int> numbers = new List<int>();
        // the num variable that will serve as the condition statement
        int number;

        // The opening statement
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            // Asking the user for a number
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine().ToString());

            // making sure that 0 does get pushed to the list
            if (number == 0)
            {
                break;
            }

            // appending the users input to the numbers list
            numbers.Add(number);

        } while (number != 0);

        // getting the sum of the list
        int sum = 0;

        foreach (int num in numbers)
        {
            sum += num;
        }

        Console.WriteLine($"The sum is {sum}");

        // Getting the average
        float countList = numbers.Count;
        double average = sum / countList;

        Console.WriteLine($"The average is {average}");

        // Will sort the numbers list here
        numbers.Sort();

        // Getting the largest number
        int largeNum = numbers[0];

        foreach (int num in numbers)
        {
            if (num > largeNum)
            {
                largeNum = num;
            }
        }

        Console.WriteLine($"The largest number {largeNum}");

        // Getting the lowest positive number in the numbers list
        int count = 0;
        // lowest number
        int lowestNum = numbers[0];

        foreach (int num in numbers)
        {

            if (num > 0)
            {
                lowestNum = num;
                break;
            }
        }

        Console.WriteLine($"The smallest positive number is {lowestNum}");
        Console.WriteLine("The sorted list is: ");
        
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}