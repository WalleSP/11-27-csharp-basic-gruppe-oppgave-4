using System.Collections;

namespace _11_27_csharp_basic_gruppe_oppgave_4;

public class TouchCommand
{
    public void Touch(string filePath)
    {
        if (File.Exists(filePath)) // Checks if the file exist and if not then creates it
        {
            Console.WriteLine("File already Exists");
        }
        else
        {
            File.Create(filePath).Close();
        }
    }
}
