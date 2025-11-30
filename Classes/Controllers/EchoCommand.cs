using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.Marshalling;

namespace _11_27_csharp_basic_gruppe_oppgave_4;

public class EchoCommand
{
    public void Echo(string[] newArgs)
    {
        string inputText;
        string filePath;

        if (!(newArgs.Length == 0))
        {
            string[] remainingElements = newArgs.ToArray();

            for (int i = 1; i < remainingElements.Count(); i++)
            {
                if (remainingElements[i] == ">")
                {
                    inputText = string.Join(" ", newArgs.Skip(1).TakeWhile(arg => arg != ">"));
                    filePath = remainingElements[i + 1];
                    File.WriteAllText(filePath, inputText);
                    Console.WriteLine($"Overwrote '{filePath}' with new content.");
                }
                else if (remainingElements[i] == ">>")
                {
                    inputText = string.Join(" ", newArgs.Skip(1).TakeWhile(arg => arg != ">>"));
                    filePath = remainingElements[i + 1];
                    File.WriteAllText(filePath, inputText);
                    Console.WriteLine($"Appended content to '{filePath}'.");
                }
            }
        }
        else
        {
            Console.WriteLine(
                string.Join(" ", newArgs.Skip(1).TakeWhile(arg => arg != ">>" && arg != ">"))
            );
        }
    }
}
