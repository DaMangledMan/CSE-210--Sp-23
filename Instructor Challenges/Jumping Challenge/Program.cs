using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> list_of_numbers = new List<int> {5, 1, 1};
        List<int> useless_indexes = new List<int> ();

        int current_index = 0;
        int final_index = list_of_numbers.Count - 1;

        useless_indexes.Add(0);
        

        while (current_index != final_index)
        {
            if (((current_index - list_of_numbers[current_index]) == final_index) || ((current_index + list_of_numbers[current_index]) == final_index))
            {
                Console.WriteLine("Yes, there is a way to jump through the list.");
                break;
            }
            if (((final_index - list_of_numbers[current_index]) < 0) || ((current_index - list_of_numbers[current_index]) <= 0))
            {
                useless_indexes.Add(current_index);
                continue;
            } else
            {
                foreach (int n in useless_indexes)
                {
                    if ((current_index - list_of_numbers[current_index]) == n)
                    {
                        foreach (int m in useless_indexes)
                        {
                            if ((current_index + list_of_numbers[current_index]) == m)
                            {
                                useless_indexes.Add(current_index);
                                continue;
                            }
                        }
                    }
                }
            }
            
            Console.WriteLine(list_of_numbers[current_index]);
            break;
        }
    }
}