namespace _11_27_csharp_basic_gruppe_oppgave_4
{
  public class LsCommand
  {
    public void ls(string[] newArgs)
    {
      string path = Environment.CurrentDirectory;
      var info = new DirectoryInfo(path);

      if (newArgs.Contains("-l"))
      {
        foreach (var file in info.GetFiles())
        {
          Console.WriteLine(
              $"{file.Attributes}  {file.Length,8}  {file.CreationTime:dd-MM.yyyy HH:mm}  {file.Name}"
          );
        }
      }
      else
      {
        foreach (var file in info.GetFiles())
        {
          Console.WriteLine(file.Name);
        }
      }
    }
  }
}
