namespace _11_27_csharp_basic_gruppe_oppgave_4.Classes.Controllers;

public class CpCommand
{
    public void cp(string sourceFileName, string destFileName)
    {
        File.Copy(sourceFileName, destFileName);
    }
}
