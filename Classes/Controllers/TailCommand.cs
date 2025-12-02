namespace _11_27_csharp_basic_gruppe_oppgave_4;

public class TailCommand
{
  public void Tail(string filePath)
  {
    if (File.Exists(filePath))
    {
      IEnumerable<string> lastLines = File.ReadLines(filePath).Reverse().Take(10).Reverse();

      foreach (var lines in lastLines)
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
