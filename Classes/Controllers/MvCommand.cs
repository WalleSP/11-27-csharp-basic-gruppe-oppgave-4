public class MvCommand
{
    public static void Mv(string fileName, string filePath)
    {
        File.Move(fileName, filePath);
        Console.WriteLine($"Your file '{fileName}' got moved to '{filePath}'");
    }
}
