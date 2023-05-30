public class Display
{
    // calls child classes
    Scripture scripture = new Scripture("1 Nephi 1:1", "I, Nephi, having been born of goodly parents, therefore I was taught somewhat in all the learning of my father; and having seen many afflictions in the course of my days, nevertheless, having been highly favored of the Lord in all my days; yea, having had a great knowledge of the goodness and the mysteries of God, therefore I make a record of my proceedings in my days.");
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