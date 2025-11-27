/// <summary>
/// Touch command from UNIX that creates a new file.
/// </summary>
public class TouchCommand
{
    public void Touch(string filePath)
    {
        File.Create(filePath);

    }
}
