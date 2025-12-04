namespace _11_27_csharp_basic_gruppe_oppgave_4;

// Pwd command
public class PwdCommand
{
    public static void Pwd() // Replays the current path
    {
        var path = Environment.CurrentDirectory;

        Console.WriteLine(path);
    }
}
