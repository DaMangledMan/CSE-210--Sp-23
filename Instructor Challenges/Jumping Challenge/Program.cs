using System;

class Program
{
    static void Main(string[] args)
    {
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

        // checks if the move is possible and returns false if it is
        static bool not_possible_move(string direction, int current_index, int final_index, int distance)
        {
            bool true_false = new bool();
            if (possible_move(direction, current_index, final_index, distance))
            {
                true_false = false;
            } else
            {
                true_false = true;
            }
            return true_false;
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
        
        // returns the new index after adding/subtracting the distance from the current index
        static int make_move(string direction, int current_index, int distance)
        {
            int new_index = new int();

            if (direction == "R")
            {
                new_index = current_index + distance;
            } else if (direction == "L")
            {
                new_index = current_index - distance;
            }

            return new_index;
        }
        














        List<int> puzzle_list = new List<int> {5, 1, 1};
        List<int> current_line = new List<int> ();
        List<int> useless_indexes = new List<int> ();

        int current_index = 0;
        int final_index = puzzle_list.Count - 1;

        useless_indexes.Add(0);
        
        int distance = puzzle_list[current_index];

        

        // this block checks if any move is useful
        // it makes the move if it is or adds it to the useless index list otherwise
        if (useful_move("R", current_index, distance, current_line, useless_indexes))
        {
            current_index = make_move("R", current_index, distance);
        } else if (useful_move("L", current_index, distance, current_line, useless_indexes))
        {
            current_index = make_move("L", current_index, distance);
        } else
        {
            useless_indexes.Add(current_index);
        }



        




    }
}