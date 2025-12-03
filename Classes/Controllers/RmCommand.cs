namespace _11_27_csharp_basic_gruppe_oppgave_4.Classes.Controllers;

public static class RmCommand
{
    public static void Rm(string newArgs, string name)
    {
        var file = Path.Combine(Directory.GetCurrentDirectory(), name);

        if (newArgs.Contains("-r"))
        {
            if (Directory.Exists(file))
            {
                Directory.Delete(file, true);
                Console.WriteLine($"Directory '{file}' successfully Deleted");
            }
            else
            {
                Console.WriteLine($"The directory {file} allready exists");
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
