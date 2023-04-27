using System;

class Program
{
    static void Main(string[] args)
    {
        Random Rnd = new Random();
                
        // checks if the move is possible and returns true if it is
        static bool possible_move(string direction, int current_index, int final_index, int distance)
        {
            bool possible = new bool();
            if (direction == "R")
            {
                if (current_index + distance > final_index)
                {
                    possible = false;
                } else
                {
                    possible = true;
                }
            } else if (direction == "L")
            {
                if (current_index - distance <= 0)
                {
                    possible = false;
                } else
                {
                    possible = true;
                }
            }
            return possible;
        }

        // checks if the move is useful and returns true if it is
        static bool useful_move(string direction, int current_index, int distance, List<int> current_line, List<int> useless_indexes)
        {
            int right_left = 0;
            if (direction == "R")
            {
                right_left = 1;
            } else 
            {
                right_left = -1;
            }

            foreach (int i in current_line)
            {
                if (current_index + (right_left * distance) == i)
                {
                    return false;
                }
            }

            foreach (int i in useless_indexes)
            {
                if (current_index + (right_left * distance) == i)
                {
                    return false;
                }
            }

            return true;
        }

        // creates the lists used and needed for the program
        List<int> puzzle_list = new List<int> {};
        List<int> current_line = new List<int> {0};
        List<int> useless_indexes = new List<int> {0};

        // fills the puzzle list with a random number of random numbers
        for (int i = 0; i < Rnd.Next(30, 151); i++)
        {
            puzzle_list.Add(Rnd.Next(1, 21));
        }

        // sets what the index of the final position of the puzzle list
        int final_index = puzzle_list.Count - 1;

        // displays the puzzle list for user to see
        Console.WriteLine("\n\nThe puzzle list is:");
        foreach (int i in puzzle_list)
        {
            Console.Write($"{i}, ");
        }
        Console.WriteLine("\n\n");

        // starts loop
        while (true)
        {
            // sets the new current index
            int current_index = current_line[current_line.Count() - 1];

            // checks if we are already at the end
            if (current_index == final_index)
            {
                Console.WriteLine("There is a way to the end. The first line of indexes we found was:");
                foreach (int i in current_line)
                {
                    Console.Write($"{i}  ");
                }
                Console.WriteLine("\n\n");
                break;
            }
            
            //sets the distance we are able to move
            int distance = puzzle_list[current_index];

            // checks possibility and usefulness of moving to the right
            if (possible_move("R", current_index, final_index, distance) && useful_move("R", current_index, distance, current_line, useless_indexes))
            {
                // adds the new index to the current line
                current_line.Add(current_index + distance);
            } 
            // checks possibility and usefulness of moving to the left
            else if (possible_move("L", current_index, final_index, distance) && useful_move("L", current_index, distance, current_line, useless_indexes))
            {
                // adds the new index to the current line
                current_line.Add(current_index - distance);
            }
            // checks if the current index is 0
            else if (current_index == 0)
            {
                Console.WriteLine("There is no possible route to the final index.\n\n");
                break;
            }            
            // if no move is possible or useful it marks the current index as useless
            else
            {
                useless_indexes.Add(current_index);
                current_line.RemoveAt(current_line.Count() - 1);
            }
        }
    }
}