namespace _11_27_csharp_basic_gruppe_oppgave_4;

public class CommandExecute
{
    public static void ProcessCommand(string[] newArgs)
    {
        string command = newArgs[0].ToLower();

        switch (command)
        {
            case "touch":
                if (newArgs.Length > 1)
                {
                    TouchCommand.Touch(newArgs[1]);
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
                HelpCommand.help();
                break;

            case "ls":
                LsCommand.ls(newArgs);
                break;

            case "cp":
                if (newArgs.Length >= 4)
                {
                    CpCommand.cp(newArgs[1], newArgs[2], newArgs[3]);
                }
                else if (newArgs.Length == 3)
                {
                    CpCommand.cp("", newArgs[1], newArgs[2]);
                }
                else
                {
                    Console.WriteLine("Usage: cp [-r] source destination");
                }
                break;

            case "cat":
                if (newArgs.Length > 1)
                {
                    CatCommand.Cat(newArgs[1]);
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
                    WcCommand.Wc(newArgs[1]);
                }
                else
                {
                    Console.WriteLine("Error: wc requires a file path.");
                }
                break;

            case "echo":

                if (newArgs.Length > 0)
                {
                    EchoCommand.Echo(newArgs);
                }
                else
                {
                    Console.WriteLine($"Unknown command: {command}");
                }
                break;

            case "mkdir":
                MkdirCommand.Mkdir(newArgs);
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
                    TailCommand.Tail(newArgs[1]);
                }
                else
                {
                    Console.WriteLine("Error: tail requires a filepath");
                }
                break;

            case "cd":
                CdCommand.Cd(newArgs);
                break;

            default:
                Console.WriteLine($"Unknown command: {command}");
                break;
        }
    }
}
