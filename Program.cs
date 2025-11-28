//// <summary>
//// Main program file that handles user input and command execution.
//// </summary>

namespace _11_27_csharp_basic_gruppe_oppgave_4
{
    class Program
    {
        static void Main(string[] args)
        {
            TouchCommand touchCommand = new TouchCommand();
            LsCommand lsCommand = new LsCommand();
            CatCommand catCommand = new CatCommand();
            WcCommand wcCommand = new WcCommand();
<<<<<<< HEAD
            CpCommand cpCommand = new CpCommand();
=======
>>>>>>> 41d38ef10126782a6f44076f58ab4eb543001927

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
<<<<<<< HEAD

                ProcessCommand(newArgs, touchCommand, lsCommand, catCommand, wcCommand, cpCommand);
            }
        }

=======
                ProcessCommand(newArgs, touchCommand, lsCommand, catCommand, wcCommand);
            }
        }

        //Made this to reduce indentation in Main method
>>>>>>> 41d38ef10126782a6f44076f58ab4eb543001927
        static void ProcessCommand(
            string[] newArgs,
            TouchCommand touchCommand,
            LsCommand lsCommand,
            CatCommand catCommand,
<<<<<<< HEAD
            WcCommand wcCommand,
            CpCommand cpCommand
=======
            WcCommand wcCommand
>>>>>>> 41d38ef10126782a6f44076f58ab4eb543001927
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

<<<<<<< HEAD
                case "cp":
                    cpCommand.cp(newArgs[1], newArgs[2]);
                    break;

=======
>>>>>>> 41d38ef10126782a6f44076f58ab4eb543001927
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
