/// <summary>
/// Cat command from UNIX that reads all text from file.
/// </summary>
public class CatCommand
{
    public void Cat(string filePath)
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("Could not find file.");
        }
        else
        {
            string fileContent = File.ReadAllText(filePath);
            Console.WriteLine(fileContent);
        }
    }
}
