using System.ComponentModel.Design;
using Spectre.Console;

namespace _11_27_csharp_basic_gruppe_oppgave_4;

public class TableCommand
{
    public void table()
    {
        var menu = new Table().Border(TableBorder.Rounded);
        Console.WriteLine();
        menu.Title("C# Goats");
        menu.AddColumn("Command");
        menu.AddColumn("Discription");
        menu.AddRow("help", "Shows this menu");
        menu.AddRow("pwd", "Shows your current path");
        menu.AddRow("ls", "Shows all the files in your current Directory");
        menu.AddRow("echo", "Prints your text in the terminal or redirects output to a file (> or >>).");
        menu.AddRow("echo", "Return your text in the terminal or writes your text into the fil");
        menu.AddRow("cat", "Display the conntent of the file");
        menu.AddRow("tail", "Display last 10 lines of file");
        menu.AddRow("touch", "Create an file");
        menu.AddRow("rm", "Delete an file");
        menu.AddRow("mv", "Moves an file or change the name");
        menu.AddRow("wc", "Shows how much words, lines, bytes and characters the file has");
        menu.AddRow("exit", "Exit the program");
        AnsiConsole.Write(menu);
    }
}
