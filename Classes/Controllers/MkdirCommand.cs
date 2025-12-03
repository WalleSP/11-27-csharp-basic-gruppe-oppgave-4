namespace _11_27_csharp_basic_gruppe_oppgave_4.Classes.Controllers;

public class MkdirCommand
{
    public void Mkdir(string[] newArgs)
    {
        if (newArgs.Length < 2)
        {
            Console.WriteLine("Error: 'mkdir' command requires a directory name.");
            return;
        }

        string[] dirNameParts = newArgs.Skip(1).ToArray(); // Skip the command itself
        string dirName = string.Join(" ", dirNameParts); // Join the remaining parts to form the directory name

        try
        {
            Directory.CreateDirectory(dirName); // Create the directory
            Console.WriteLine($"Directory '{dirName}' created successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error creating directory '{dirName}': {ex.Message}");
        }
    }
}
