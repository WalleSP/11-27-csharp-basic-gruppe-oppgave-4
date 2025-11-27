namespace _11_27_csharp_basic_gruppe_oppgave_4.LsCommand;

public class LsCommand()
{
    public void ls()
    {
        string path = Environment.CurrentDirectory;
        string[] files = Directory.GetFiles(path);
        foreach (string file in files)
        {
            Console.WriteLine(Path.GetFileName(file));
        }
    }
}
