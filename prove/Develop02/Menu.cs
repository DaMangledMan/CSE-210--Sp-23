public class Menu
{
    Prompt Prompt = new Prompt();
    Journal Journal = new Journal();
    
    // methods
    // menu to select which option you mant


    public void menu()
    {
        int option;
        while (true)
        {
            try
            {
                Console.Write("\nWhich option would you like to choose ( 1 - 5 )?\n");
                Console.WriteLine(" 1. Write\n 2. Display\n 3. Load\n 4. Save\n 5. Quit\n");
                option = int.Parse(Console.ReadLine());

                if (option >= 1 && option <= 5)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Your Input was not one of the options.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("the input was not in the correct format. Integers only.");
            }
        }

        if (option == 5)
        {
            Quit();
        }

        if (option == 1)
        {
            Write();
        }
        else if (option == 2)
        {
            Display();
        }
        else if (option == 3)
        {
            Load();
        }
        else if (option == 4)
        {
            Save();
        }
    }

    // option 5: quit
    public void Quit()
    {
        Environment.Exit(1);
    }

    // option 1: write
    public void Write()
    {
        string prompt = Prompt.randomPrompt();
        Console.Write(prompt);
        string entry = Console.ReadLine();
        Journal.addEntry(prompt, entry);
    }

    // option 2: display
    public void Display()
    {
        Journal.display();
    }

    // option 3: load
    public void Load()
    {
        string fileName ;
        Console.Write("What is the name of the file?\n");
        fileName = Console.ReadLine();
        Journal.loadOldJournal(fileName);
    }

    // option 4: save
    public void Save()
    {
        int choice ;
        while (true)
        {
            try
            {
                Console.Write("\nDo you want to:\n\n1. create a new file / overwrite an existing one \nor\n2. add your new entries to an existing file\n\n");
                choice = int.Parse(Console.ReadLine());

                if (choice >= 1 && choice <= 2)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Your Input was not one of the expected choices.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("The Input was not in the correct format. Integers only.");
            }
        }

        string fileName ;
        Console.Write("\nWhat is the name of the file?\n\n5");
        fileName = Console.ReadLine();

        if (choice == 1)
        {
            Journal.OverWrite(fileName);
        }
        else if (choice == 2)
        {
            Journal.Append(fileName);
        }
    }
}