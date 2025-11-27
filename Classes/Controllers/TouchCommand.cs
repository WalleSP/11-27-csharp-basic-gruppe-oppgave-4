/// <summary>
/// Simple Touch command from UNIX
/// </summary>

public class TouchCommand
{
    public void Touch(string filePath)
    {
        File.Create(filePath);
    }

}