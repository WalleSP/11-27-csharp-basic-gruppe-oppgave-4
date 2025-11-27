namespace _11_27_csharp_basic_gruppe_oppgave_4
{


// Pwd command
public class PwdCommand
{
    public void pwd()
    {
        var path = Environment.CurrentDirectory;

        Console.WriteLine(path);
    }
}
}