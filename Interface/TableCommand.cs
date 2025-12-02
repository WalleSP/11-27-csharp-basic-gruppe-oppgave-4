using Spectre.Console;
using Spectre.Console.Rendering;

namespace _11_27_csharp_basic_gruppe_oppgave_4;

public class TableCommand
{
    public void table()
    {
        var menu = new Table().Border(TableBorder.Rounded);
        Console.WriteLine();
        menu.ShowRowSeparators();
        menu.Title("C# Goats");
        menu.AddColumn("[bold cyan]Command[/]").LeftAligned();
        menu.AddColumn("[bold cyan]Discription[/]");
        menu.AddRow("help", "Shows this menu.");
        menu.AddRow("pwd", "Shows your current path.");
        menu.AddRow(
            "ls",
            "Shows all the files in your current directory.\nUse 'ls -l' to show more details."
        );
        menu.AddRow(
            "echo",
            "Prints your text in the terminal or an file.\nUse > or >> to redirect output to a file."
        );
        menu.AddRow("cat", "Display the conntent of the file.");
        menu.AddRow("tail", "Display last 10 lines of file.");
        menu.AddRow("touch", "Create an file.");
        menu.AddRow("rm", "Delete an file.\nUse -r to delete a directory with the files inside.");
        menu.AddRow("mv", "Moves an file or change the name.");
        menu.AddRow("wc", "Shows how much words, lines, bytes and characters the file has.");
        menu.AddRow("mkdir", "Create an directory.");
        menu.AddRow("exit", "Exit the program.");
        AnsiConsole.Write(menu);
    }
}
