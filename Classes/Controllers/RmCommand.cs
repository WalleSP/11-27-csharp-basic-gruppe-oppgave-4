namespace _11_27_csharp_basic_gruppe_oppgave_4;

public static class RmCommand
{
    public static void Rm(string fileName)
    {
        File.Delete(fileName);
    }
}
