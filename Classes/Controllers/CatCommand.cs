namespace _11_27_csharp_basic_gruppe_oppgave_4;

public class CatCommand
{
    public static void Cat(string filePath)
    {
        if (!File.Exists(filePath)) //Checks if file provided by filepath exist
        {
            Console.WriteLine("Could not find file.");
        }
        else
        {
            string fileContent = File.ReadAllText(filePath); //If the file exist, it reads and write the content of the file to the terminal
            Console.WriteLine(fileContent);
        }
    }
}
