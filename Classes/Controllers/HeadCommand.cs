namespace _11_27_csharp_basic_gruppe_oppgave_4.Classes;

public class HeadCommand
{
    public static void Head(string FilePath)
    {
        if (File.Exists(FilePath))
        {
            IEnumerable<string> firstLines = File.ReadLines(FilePath).Take(10);

            foreach (var lines in firstLines)
            {
                Console.WriteLine(lines);
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
