namespace _11_27_csharp_basic_gruppe_oppgave_4
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            
            TouchCommand touchCommand = new TouchCommand();
            LsCommand lsCommand = new LsCommand();
            CatCommand catCommand = new CatCommand();
            WcCommand wcCommand = new WcCommand();
=======
            case "touch":
                touchCommand.Touch(args[1]);
                break;

            case "pwd":
                PwdCommand.Pwd();
                break;

            case "cat":
                catCommand.Cat(args[1]);
                break;
>>>>>>> 4bf6f84b08bfa6f924278cae228b2255a48c1b2c

            bool exitFlag = false;

            while (!exitFlag)
            {
                Console.Write("> ");
                string? input = Console.ReadLine();

                // 1. Input Validation and Early Exit
                if (string.IsNullOrWhiteSpace(input))
                {
                    continue;
                }

                string[] newArgs = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string command = newArgs[0].ToLower();

                if (command == "exit")
                {
                    exitFlag = true;
                    continue; // exit the loop
                }
                
                ProcessCommand(newArgs, touchCommand, lsCommand, catCommand, wcCommand);
            }
        }
        
        
        static void ProcessCommand(
            string[] newArgs,
            TouchCommand touchCommand,
            LsCommand lsCommand,
            CatCommand catCommand,
            WcCommand wcCommand)
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