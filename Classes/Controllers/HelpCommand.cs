namespace _11_27_csharp_basic_gruppe_oppgave_4;

public class HelpCommand
{
    public void help()
    {
        // Get the help menu if the user write help
        TableCommand tableCommand = new TableCommand();
        Console.Clear();
        tableCommand.table();
    }
}
