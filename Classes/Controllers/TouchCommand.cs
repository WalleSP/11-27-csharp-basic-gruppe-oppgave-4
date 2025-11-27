/// <summary>
/// Simple Touch command from UNIX
/// </summary>
public class TouchCommand
{
    public void Touch(string filePath)
    {
        if (File.Exists(filePath))
        {
            Console.WriteLine("File already Exists");
        }
        else
        {
            File.Create(filePath);
        }
    }
}
