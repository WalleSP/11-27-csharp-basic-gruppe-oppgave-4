namespace _11_27_csharp_basic_gruppe_oppgave_4;

public class MwCommands
{
    public void Mv(string fileName, string filePath)
    {
        File.Move(fileName, filePath);
    }
}
