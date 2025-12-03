namespace _11_27_csharp_basic_gruppe_oppgave_4;

public class MvCommand
{
    public static void Mv(string source, string dest)
    {
        if (Directory.Exists(dest))
        {
            string fileName = Path.GetFileName(source);
            dest = Path.Combine(dest, fileName);
        }

        if (Directory.Exists(source))
        {
            Directory.Move(source, dest);
            Console.WriteLine($"Directory moved to '{dest}'");
        }

        if (File.Exists(source))
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
