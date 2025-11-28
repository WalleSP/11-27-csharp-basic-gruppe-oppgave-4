using Spectre.Console;

namespace _11_27_csharp_basic_gruppe_oppgave_4;

public class Table
{
    public void table()
    {
        var menu = new Table().Border(TableBorder.Rounded);
        menu.AddColumn("[bold]Velkommen Roan![/]");
        Console.ReadLine();
    }
}
