public class MvCommand
{
    public static void Mv(string fileName, string filePath)
    {
        File.Move(fileName, filePath);
    }
}
