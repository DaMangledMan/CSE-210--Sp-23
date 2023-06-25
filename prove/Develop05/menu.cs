public class Menu
{
    Points points = new Points();
    csvEditor CSV = new csvEditor();
    
    // attributes
    private List<Goal> goalsList = new List<Goal> ();

    // constructor
    // n/a

    // methods
    public void menu()
    {
        load();
        
        while (true)
        {        
            Console.Clear();

            int option;
            while (true)
            {
                try
                {
                    displayPoints();
                    Console.Write("\nWhich option would you like to choose ( 1 - 5 )?\n");
                    Console.WriteLine(" 1. Create\n 2. List\n 3. Save\n 4. Record\n 5. Quit\n");
                    option = int.Parse(Console.ReadLine());
    
                    if (option >= 1 && option <= 5)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nYour Input was not one of the options.\n\nclick 'ENTER' to continue");
                        Console.ReadLine();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nThe input was not in the correct format. Integers only.\n\nclick 'ENTER' to continue");
                    Console.ReadLine();
                }
            }

            if (option == 1)
            {
                create();
            }
            else if (option == 2)
            {
                list();
            }
            else if (option == 3)
            {
                save();
            }
            else if (option == 4)
            {
                record();
            }
            else if (option == 5)
            {
                quit();
            }
        }
    }

    private void create()
    {
        while (true)
        {        
            Console.Clear();

            int option;
            while (true)
            {
                try
                {
                    displayPoints();
                    Console.Write("\nWhich type of goal would you like to create ( 1 - 3 )?\n");
                    Console.WriteLine(" 1. Basic\n 2. Eternal\n 3. Bonus\n");
                    option = int.Parse(Console.ReadLine());
    
                    if (option >= 1 && option <= 3)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nYour Input was not one of the options.\n\nclick 'ENTER' to continue");
                        Console.ReadLine();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nThe input was not in the correct format. Integers only.\n\nclick 'ENTER' to continue");
                    Console.ReadLine();
                }
            }

            if (option == 1)
            {
                Console.Clear();

                string name;
                while (true)
                {
                    try 
                    {
                        Console.WriteLine("What is the Name of the Goal");
                        name = Console.ReadLine();
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("An input is required.");
                    }
                }

                string description;
                while (true)
                {
                    try 
                    {
                        Console.WriteLine("What is the Description of the Goal");
                        description = Console.ReadLine();
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("An input is required.");
                    }
                }

                int completePoints;
                while (true)
                {
                    try 
                    {
                        Console.WriteLine("How many Points do you get for Completing the Goal");
                        completePoints = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("An input is required in integer form.");
                    }
                }

                Basic n = new Basic(name, description, completePoints);
                goalsList.Add(n);
            }

            else if (option == 2)
            {
                Console.Clear();

                string name;
                while (true)
                {
                    try 
                    {
                        Console.WriteLine("What is the Name of the Goal");
                        name = Console.ReadLine();
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("An input is required.");
                    }
                }

                string description;
                while (true)
                {
                    try 
                    {
                        Console.WriteLine("What is the Description of the Goal");
                        description = Console.ReadLine();
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("An input is required.");
                    }
                }

                int continuePoints;
                while (true)
                {
                    try 
                    {
                        Console.WriteLine("How many Points do you get for Continuing the Goal");
                        continuePoints = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("An input is required in integer form.");
                    }
                }

                Eternal n = new Eternal(name, description, continuePoints);
                goalsList.Add(n);
            }

            else if (option == 3)
            {
                Console.Clear();

                string name;
                while (true)
                {
                    try 
                    {
                        Console.WriteLine("What is the Name of the Goal");
                        name = Console.ReadLine();
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("An input is required.");
                    }
                }

                string description;
                while (true)
                {
                    try 
                    {
                        Console.WriteLine("What is the Description of the Goal");
                        description = Console.ReadLine();
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("An input is required.");
                    }
                }

                int continuePoints;
                while (true)
                {
                    try 
                    {
                        Console.WriteLine("How many Points do you get for Continuing the Goal");
                        continuePoints = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("An input is required in integer form.");
                    }
                }

                int completePoints;
                while (true)
                {
                    try 
                    {
                        Console.WriteLine("How many Points do you get for Completing the Goal");
                        completePoints = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("An input is required in integer form.");
                    }
                }

                int continuesGoal;
                while (true)
                {
                    try 
                    {
                        Console.WriteLine("How many time do you want to Complete this Goal before it is marked as finished");
                        continuesGoal = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("An input is required in integer form.");
                    }
                }

                Bonus n = new Bonus(name, description, continuePoints, completePoints, continuesGoal);
                goalsList.Add(n);
            }
        }
    }

    private void list()
    {
        Console.Clear();
        Console.WriteLine("\n\n\n");
        if (goalsList.Count() == 0)
        {
            Console.WriteLine("There are no goals to list.");
            return;
        }

        foreach(Goal i in goalsList)
        {
            Console.WriteLine(i.stringifyInformation());
        }
    }

    private void save()
    {      
        Console.Clear();

        List<string> goalsListStrings = new List<string>();
        foreach (Goal i in goalsList)
        {
            goalsListStrings.Add(i.stringifyInformation());
        }
        CSV.OverWrite("goalsSaveFile.csv", goalsListStrings);
    }

    private void record()
    {

    }

    private void quit()
    {
        Environment.Exit(1);
    }

    private void load()
    {
        List<List<string>> goalsListListString = CSV.Load("goalsSaveFile.csv");

        foreach (List<string> i in goalsListListString)
        {
            if (i[0] == "Ba")
            {
                Basic n = new Basic(i[1], i[2], int.Parse(i[3]), bool.Parse(i[4]));
                goalsList.Add(n);
            }
            else if (i[0] == "Et")
            {
                Eternal n = new Eternal(i[1], i[2], int.Parse(i[3]), int.Parse(i[4]));
                goalsList.Add(n);
            }
            else if (i[0] == "Bo")
            {
                Bonus n = new Bonus(i[1], i[2], int.Parse(i[3]), int.Parse(i[4]), int.Parse(i[5]), int.Parse(i[6]), bool.Parse(i[7]));
                goalsList.Add(n);
            }
        }
    }

    private void displayPoints()
    {
        Console.WriteLine($"\n\n\nYou are currently at {points.getPointTotal()} points.\n\n   Good Job!!!");
    }
}