namespace _11_27_csharp_basic_gruppe_oppgave_4
{ 
    class Program
    {
        static void Main(string[] args)
        {
          bool exitFlag = false;

          TouchCommand touchCommand = new TouchCommand();
          LsCommand lsCommand = new LsCommand();
          PwdCommand pwdCommand = new PwdCommand();
          
          while (!exitFlag)
          {
          
            Console.Write("> ");
          string? input = Console.ReadLine();
          string[] newArgs = input!.Split(' ', StringSplitOptions.RemoveEmptyEntries);

          
          if (newArgs.Length == 0) continue; 

          
          if (newArgs[0].ToLower() == "exit")
          {
              break; 
          }

            if (newArgs.Length > 0)
            {
                
                switch (newArgs[0].ToLower())
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
                        
                        pwdCommand.pwd(); 
                        break;
                    case "ls":
                        
                        lsCommand.ls(newArgs);
                        break;

                    default:
                        Console.WriteLine($"Unknown command: {newArgs[0]}");
                        break;
                }
            }
        }
      }
    }
}