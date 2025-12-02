namespace _11_27_csharp_basic_gruppe_oppgave_4;

public class WcCommand
{
  public void Wc(string filePath)
  {
    if (File.Exists(filePath))
    {
      string content = File.ReadAllText(filePath);
      int lines = File.ReadAllLines(filePath).Length;
      int words = content
          .Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
          .Length;
      long bytes = new FileInfo(filePath).Length;
      Console.WriteLine($"\t{lines}\t{words}\t{bytes}\t{filePath}");
    }
    else
    {
      Console.WriteLine($"wc: {filePath}: No such file or directory");
    }
  }
}
