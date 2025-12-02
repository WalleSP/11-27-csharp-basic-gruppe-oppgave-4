namespace _11_27_csharp_basic_gruppe_oppgave_4;

public class MkdirCommand
{
    public void Mkdir(string[] newArgs)
    {
        if (newArgs.Length < 2)
        {
            Console.WriteLine("Error: 'mkdir' command requires a directory name.");
            return;
        }

        string[] dirNameParts = newArgs.Skip(1).ToArray();
        string dirName = string.Join(" ", dirNameParts);

        try
        {
            Directory.CreateDirectory(dirName);
            Console.WriteLine($"Directory '{dirName}' created successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error creating directory '{dirName}': {ex.Message}");
        }
    }
}
