using Spectre.Console;

/// <summary>
//// Main program file that handles user input and command execution.
//// </summary>

namespace _11_27_csharp_basic_gruppe_oppgave_4
{
    class Program
    {
        static void Main(string[] args)
        {
            AnsiConsole.MarkupLine(
                "[blue]_______________________________________________________________________[/]"
            );
            AnsiConsole.WriteLine();
            AnsiConsole.MarkupLine("help:    Shows this menu");
            AnsiConsole.MarkupLine("pwd:     Shows your current path");
            AnsiConsole.MarkupLine("ls:      Shows all the files in your current Directory");
            AnsiConsole.MarkupLine(
                "echo:    Return your text in the terminal or writes your text into an fil"
            );
            AnsiConsole.MarkupLine("cat:     Display the conntent of an file");
            AnsiConsole.MarkupLine("touch:   Create an file");
            AnsiConsole.MarkupLine("rm:      Delete an file");
            AnsiConsole.MarkupLine("mv:      Moves an file or change the name");
            AnsiConsole.MarkupLine(
                "Wc:      Shows how much words, lines, bytes and characters the file has"
            );
            AnsiConsole.MarkupLine("exit:    Exit the program");
            AnsiConsole.MarkupLine(
                "[blue]_______________________________________________________________________[/]"
            );
            AnsiConsole.WriteLine();
            AnsiConsole.MarkupLine("Choose one of the option abow");
            AnsiConsole.WriteLine();

            TouchCommand touchCommand = new TouchCommand();
            LsCommand lsCommand = new LsCommand();
            CatCommand catCommand = new CatCommand();
            WcCommand wcCommand = new WcCommand();
            CpCommand cpCommand = new CpCommand();

            bool exitFlag = false;

            while (!exitFlag) // Main loop to process user commands
            {
                Console.Write("> "); // Prompt for user input
                string? input = Console.ReadLine();

                // 1. Input Validation and Early Exit
                if (string.IsNullOrWhiteSpace(input))
                {
                    continue; // Skip empty input
                }

                string[] newArgs = input.Split(' ', StringSplitOptions.RemoveEmptyEntries); // Split input into command and arguments
                string command = newArgs[0].ToLower(); // Extract command

                if (command == "exit")
                {
                    exitFlag = true;
                    continue; // exit the loop
                }

                ProcessCommand(newArgs, touchCommand, lsCommand, catCommand, wcCommand, cpCommand);
            }
        }

        static void ProcessCommand(
            string[] newArgs,
            TouchCommand touchCommand,
            LsCommand lsCommand,
            CatCommand catCommand,
            WcCommand wcCommand,
            CpCommand cpCommand
        )
        {
            string command = newArgs[0].ToLower();

            switch (command)
            {
                case "touch":
                    if (newArgs.Length > 1)
                    {
                        touchCommand.Touch(newArgs[1]);
                    }
                    else
                    {
                        Console.WriteLine("Error: touch requires a file path.");
                    }
                    break;

                case "pwd":

                    PwdCommand.Pwd();
                    break;

                case "ls":
                    lsCommand.ls(newArgs);
                    break;

                case "cp":
                    cpCommand.cp(newArgs[1], newArgs[2]);
                    break;

                case "cat":
                    if (newArgs.Length > 1)
                    {
                        catCommand.Cat(newArgs[1]);
                    }
                    else
                    {
                        Console.WriteLine("Error: cat requires a file path.");
                    }
                    break;

                case "rm":
                    if (newArgs.Length > 1)
                    {
                        RmCommand.Rm(newArgs[1]);
                    }
                    else
                    {
                        Console.WriteLine("Error: rm requires a file path.");
                    }
                    break;

                case "wc":
                    if (newArgs.Length > 1)
                    {
                        wcCommand.Wc(newArgs[1]);
                    }
                    else
                    {
                        Console.WriteLine("Error: wc requires a file path.");
                    }
                    break;

                default:
                    Console.WriteLine($"Unknown command: {command}");
                    break;
            }
        }
    }
}
