public class Prompt
{
    Random random = new Random();

    List<string> _prompts = new List<string> {
        "Who was the most interesting person you met today? ",
        "What was the best part of my day? ",
        "How did I see the hand of the Lord in my life today? ",
        "What was the strongest emotion I felt today? ",
        "What was the worst part of your day? ",
        "Did anyhting that happened today stick out more than normal? ",
        "What was something I learned today? ",
        "Who do I want to learn more about and get to know better as a person? ",
        "How many times did I do a good deed for someone else today? "
        };

    // methods
    // returns a random prompt
    public string randomPrompt()
    {
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        return $"\n{prompt}";
    }
}