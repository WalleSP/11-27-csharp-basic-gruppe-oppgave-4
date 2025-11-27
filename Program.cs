namespace _11_27_csharp_basic_gruppe_oppgave_4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        TouchCommand touchCommand = new TouchCommand();

        switch (args[0]) 
        {
            case "touch":
                touchCommand.Touch(args[1]);
                break;

            default:
                return;
        }
    }
}
