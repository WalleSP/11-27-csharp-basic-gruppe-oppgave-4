namespace _11_27_csharp_basic_gruppe_oppgave_4;

public class PwdCommand()
{
    public static void pwd()
    {
        var path = Environment.CurrentDirectory;

        Console.WriteLine(path);
    }
}
