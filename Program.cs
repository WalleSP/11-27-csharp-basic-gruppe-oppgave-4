namespace _11_27_csharp_basic_gruppe_oppgave_4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        TouchCommand touchCommand = new TouchCommand();
        PwdCommand pwdCommand = new PwdCommand();
        CatCommand catCommand = new CatCommand();

        switch (args[0])
        {
            case "touch":
                touchCommand.Touch(args[1]);
                break;
            
            case "pwd":
                PwdCommand.Pwd();
                break;
            
            case "cat":
                catCommand.Cat(args[1]);
                break;

            default:
                return;
        }
    }
}
