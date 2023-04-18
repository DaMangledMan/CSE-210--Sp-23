using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> list_of_numbers = new List<int>();
        while (true)
        {
            try
            {
                Console.Write("What number would you like to add (type 0 when finished? ");
                int number_input = int.Parse(Console.ReadLine());
                if (number_input == 0)
                {
                    break;
                }
                else
                {
                    list_of_numbers.Add(number_input);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("the input was not in the correct format. Integers only.");
            }
        }

        int[] sorted_array = list_of_numbers.ToArray();

        Array.Sort(sorted_array);

        Console.WriteLine($"The sum is: {sorted_array.Sum()}");
        Console.WriteLine($"The average is: {(double)sorted_array.Sum() / sorted_array.Count()}");
        Console.WriteLine($"The Max is: {sorted_array.Max()}");
        Console.WriteLine($"The Min is: {sorted_array.Min()}");
        Console.WriteLine($"The sorted list is: ");
        foreach (int i in sorted_array)
        {
            Console.Write($"{i}, ");
        }
    }
}