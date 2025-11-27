
public class CatCommand
{
    public void Cat(string filePath)
    {
        string fileContent = File.ReadAllText(filePath);
        Console.WriteLine(fileContent);

    }
}