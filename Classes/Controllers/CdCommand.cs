namespace _11_27_csharp_basic_gruppe_oppgave_4;

public class CdCommand
{
    public void Cd(string[] newArgs)
    {
        if (newArgs.Length < 2)
        {
            Console.WriteLine(
                "Error: 'cd' command requires a directory name.\n"
                    + "\n"
                    + "Usage:\n"
                    + "  cd <directory>  - Change to the specified directory.\n"
                    + "  cd ..           - Go back up one directory level.\n"
            );
            return;
        }

        string[] pathInput = newArgs.Skip(1).ToArray(); //Skip the command itself
        string newPath = string.Join(" ", pathInput); //Join the remaining parts to form the directory name

        try
        {
            Directory.SetCurrentDirectory(newPath); //Change the current directory
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error changing directory to '{newPath}': {ex.Message}");
        }
        PwdCommand.Pwd();
    }
}
