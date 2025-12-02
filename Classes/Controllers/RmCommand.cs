namespace _11_27_csharp_basic_gruppe_oppgave_4;

public static class RmCommand
{
    public static void Rm(string newArgs, string name)
    {
        var directoryName = Path.GetDirectoryName(newArgs);
        var file = Path.Combine(Directory.GetCurrentDirectory(), name);

        if (newArgs.Contains("-r"))
        {
            {
                Console.WriteLine("Invalid path");
            }

            if (Directory.Exists(directoryName))
            {
                Directory.Delete(directoryName, true);
            }
            else
            {
                Console.WriteLine($"The directory {directoryName} allready exists");
            }
        }
        else
        {
            if (File.Exists(file))
            {
                File.Delete(file);
            }
            else
            {
                Console.WriteLine($"There is no file with the name {name}");
            }
        }
    }
}
