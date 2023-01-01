namespace summary_text;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var text = "The color of animals is by no means a matter of chance; it depends on many considerations, but in the majority of cases tends to protect the animal from danger by rendering it less conspicuous";
        var summaryText = StringUtilities.summary_text(text,50);

        Console.WriteLine(summaryText);
    }
}

