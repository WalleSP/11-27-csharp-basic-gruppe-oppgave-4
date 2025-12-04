namespace _11_27_csharp_basic_gruppe_oppgave_4;

public class EchoCommand
{
    public static void Echo(string[] newArgs)
    {
        if (newArgs.Length == 0)
        {
            return;
        }

        var argsWithoutCommand = newArgs.Skip(1);

        int overWriteSymbolIndex = Array.IndexOf(newArgs, ">");
        int appendSymbolIndex = Array.IndexOf(newArgs, ">>");

        string? redirectionSymbol = null;
        int redirectionIndex = -1;

        // Determine redirection type and index
        if (
            overWriteSymbolIndex != -1
            && (appendSymbolIndex == -1 || overWriteSymbolIndex < appendSymbolIndex)
        )
        {
            redirectionSymbol = ">";
            redirectionIndex = overWriteSymbolIndex;
        }
        else if (appendSymbolIndex != -1)
        {
            redirectionSymbol = ">>";
            redirectionIndex = appendSymbolIndex;
        }

        // Handle Redirection
        if (redirectionIndex != -1)
        {
            // Ensure there is content before the redirection symbol and a file path after it
            if (redirectionIndex > 1 && redirectionIndex + 1 < newArgs.Length)
            {
                string[] contentArguments = argsWithoutCommand
                    .TakeWhile(arg => arg != redirectionSymbol)
                    .ToArray();

                string inputText = string.Join(" ", contentArguments);
                string filePath = newArgs[redirectionIndex + 1];

                // Perform file write or append
                if (redirectionSymbol == ">")
                {
                    File.WriteAllText(filePath, inputText);
                    Console.WriteLine($"Overwrote '{filePath}' with new content.");
                }
                else
                {
                    File.AppendAllText(filePath, inputText + Environment.NewLine);
                    Console.WriteLine($"Appended content to '{filePath}'.");
                }
            }
            else
            {
                // Invalid usage of redirection
                Console.WriteLine("Error: Use echo <content> > <filepath>");
            }
        }
        //No redirection, just print to console)
        else if (newArgs.Length > 1)
        {
            string outputText = string.Join(" ", argsWithoutCommand);
            Console.WriteLine(outputText);
        }
        // Only "echo" command without arguments
        else if (newArgs.Length == 1)
        {
            Console.WriteLine();
        }
    }
}
