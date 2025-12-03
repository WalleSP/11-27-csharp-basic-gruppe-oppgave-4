using _11_27_csharp_basic_gruppe_oppgave_4.Classes;
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
            var touchCommand = new TouchCommand();
            var lsCommand = new LsCommand();
            var catCommand = new CatCommand();
            var wcCommand = new WcCommand();
            var cpCommand = new CpCommand();
            var echoCommand = new EchoCommand();
            var helpCommand = new HelpCommand();
            var headCommand = new HeadCommand();
            var tailCommand = new TailCommand();
            var mkdirCommand = new MkdirCommand();
            var mvCommand = new MvCommand();
            var cdCommand = new CdCommand();

            var tableCommand = new TableCommand();
            tableCommand.table();

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

                ProcessCommand(
                    newArgs,
                    touchCommand,
                    lsCommand,
                    catCommand,
                    wcCommand,
                    cpCommand,
                    echoCommand,
                    helpCommand,
                    mkdirCommand,
                    tailCommand,
                    mvCommand,
                    cdCommand
                );
            }
        }

        static void ProcessCommand(
            string[] newArgs,
            TouchCommand touchCommand,
            LsCommand lsCommand,
            CatCommand catCommand,
            WcCommand wcCommand,
            CpCommand cpCommand,
            EchoCommand echoCommand,
            HelpCommand helpCommand,
            MkdirCommand mkdirCommand,
            TailCommand tailCommand,
            MvCommand mvCommand,
            CdCommand cdCommand
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

                case "mv":
                    MvCommand.Mv(newArgs[1], newArgs[2]);
                    break;

                case "help":
                    helpCommand.help();
                    break;

                case "ls":
                    lsCommand.ls(newArgs);
                    break;

                case "cp":
                    if (newArgs.Length >= 4)
                    {
                        cpCommand.cp(newArgs[1], newArgs[2], newArgs[3]);
                    }
                    else if (newArgs.Length == 3)
                    {
                        cpCommand.cp("", newArgs[1], newArgs[2]);
                    }
                    else
                    {
                        Console.WriteLine("Usage: cp [-r] source destination");
                    }
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
                        if (newArgs.Contains("-r"))
                        {
                            RmCommand.Rm(newArgs[1], newArgs[2]);
                        }
                        else
                        {
                            RmCommand.Rm("", newArgs[1]);
                        }
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

                case "echo":

                    if (newArgs.Length > 0)
                    {
                        echoCommand.Echo(newArgs);
                    }
                    else
                    {
                        Console.WriteLine($"Unknown command: {command}");
                    }
                    break;

                case "mkdir":
                    mkdirCommand.Mkdir(newArgs);
                    break;

                case "head":
                    if (newArgs.Length > 1)
                    {
                        HeadCommand.Head(newArgs[1]);
                    }
                    else
                    {
                        Console.WriteLine("Error: head requires a filepath");
                    }
                    break;

                case "tail":
                    if (newArgs.Length > 1)
                    {
                        tailCommand.Tail(newArgs[1]);
                    }
                    else
                    {
                        Console.WriteLine("Error: tail requires a filepath");
                    }
                    break;

                case "cd":
                    cdCommand.Cd(newArgs);
                    break;

                default:
                    Console.WriteLine($"Unknown command: {command}");
                    break;
            }
        }
    }
}
