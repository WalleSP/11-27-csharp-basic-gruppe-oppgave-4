namespace _11_27_csharp_basic_gruppe_oppgave_4;

public class MvCommand
{
    public static void Mv(string source, string dest)
    {
        if (Directory.Exists(dest)) // Checks if destination directory exist
        {
            string fileName = Path.GetFileName(source);
            dest = Path.Combine(dest, fileName);
        }

        if (Directory.Exists(source)) // Checks if the source directory exist, if yes then it moves the directory
        {
            Directory.Move(source, dest);
            Console.WriteLine($"Directory moved to '{dest}'");
        }

        if (File.Exists(source)) // Checks if the file exist, if yes then it moves the fil to destination
        {
            File.Move(source, dest, true);
            Console.WriteLine($"Your file '{source}' moved successfully");
        }
        else
        {
            Console.WriteLine($"Your '{source}' not found");
        }
    }
}
