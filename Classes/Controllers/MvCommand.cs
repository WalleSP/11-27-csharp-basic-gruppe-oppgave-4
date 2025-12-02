public class MwCommands
{
    public void Mv(string fileName, string filePath)
    {
        File.Move(fileName, filePath);
    }
}
