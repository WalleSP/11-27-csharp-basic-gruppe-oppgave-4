namespace _11_27_csharp_basic_gruppe_oppgave_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var tableCommand = new TableCommand();
            TableCommand.table();

bool exitFlag = false;

// Main loop to process user commands
while (!exitFlag)
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

    CommandExecute.ProcessCommand(newArgs, command);
}
