namespace _11_27_csharp_basic_gruppe_oppgave_4;

public static class RmCommand
{
    public static void Rm(string newArgs, string name)
    {
        var file = Path.Combine(Directory.GetCurrentDirectory(), name); //Combines the path with the name

        if (newArgs.Contains("-r")) // If newArgs contains 'r' then the program deletes the directory if it exist
        {
            if (Directory.Exists(file))
            {
                Directory.Delete(file, true);
                Console.WriteLine($"Directory '{file}' successfully Deleted");
            }
            else
            {
                Console.WriteLine($"The directory {file} dont exists");
            }
        }
        else
        {
            if (File.Exists(file)) // Deletes the file when it exist
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
