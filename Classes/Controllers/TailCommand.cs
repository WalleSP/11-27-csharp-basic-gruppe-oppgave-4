namespace _11_27_csharp_basic_gruppe_oppgave_4;

public class TailCommand
{
    public void Tail(string filePath)
    {
        if (File.Exists(filePath)) // If the file exist it read the last lines of the file and gives output to the user
        {
            IEnumerable<string> lastLines = File.ReadLines(filePath).Reverse().Take(10).Reverse();

            foreach (var lines in lastLines)
            {
                Console.WriteLine(lines);
            }
        }
        else
        {
            Console.WriteLine($"File '{filePath}' not found.");
        }
    }
}
