namespace _11_27_csharp_basic_gruppe_oppgave_4.Classes.Controllers;

public class HelpCommand
{
    public void help()
    {
        TableCommand tableCommand = new TableCommand();
        Console.Clear();
        tableCommand.table();
    }
}
