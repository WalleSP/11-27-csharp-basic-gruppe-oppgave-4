namespace _11_27_csharp_basic_gruppe_oppgave_4;

public static class RmCommand
{
  public static void Rm(string fileName)
  {
    var file = Path.Combine(Directory.GetCurrentDirectory(), fileName);
    if (File.Exists(file))
    {
      File.Delete(file);
    }
    else
    {
      Console.WriteLine($"There is no file with the name {fileName} ");
    }
  }
}
