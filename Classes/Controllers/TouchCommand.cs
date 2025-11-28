using System.Collections;

namespace _11_27_csharp_basic_gruppe_oppgave_4
{
    /// <summary>
    /// Touch command from UNIX that creates a new file.
    /// </summary>
    public class TouchCommand
    {
        public void Touch(string filePath)
        {
            if (File.Exists(filePath))
            {
                Console.WriteLine("File already Exists");
            }
            else
            {
                File.Create(filePath).Close();
            }
        }
    }
}
