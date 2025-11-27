namespace _11_27_csharp_basic_gruppe_oppgave_4
{


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
}
