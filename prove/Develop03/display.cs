public class Display
{
    // calls child classes
    Scripture scripture = new Scripture("1 Nephi 2:15", "And my father dwelt in a tent.");
    Hide hide = new Hide(scripture.getScriptureList);

    // methods
    public void Display();
    {
        console.Writeline(Hide.stringify());
    }
}