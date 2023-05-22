public class Display
{
    // calls child classes
    Scripture scripture = new Scripture("1 Nephi 2:15", "And my father dwelt in a tent.");
    Hide hide;

    public Display(){
        hide = new Hide(scripture.getScriptureList());
    }

    // methods
    public void displayFullVerse()
    {
        Console.Clear();
        Console.WriteLine($"{scripture.getHeader()} : {scripture.getScripture()}");
    }
    
    public void displayHidden()
    {
        hide.hideThreeWords();
        Console.Clear();
        Console.WriteLine($"{scripture.getHeader()} : {hide.stringify()}");
    }

    public bool completelyHidden()
    {
        return hide.completelyHidden();
    }
}