namespace _11_27_csharp_basic_gruppe_oppgave_4;

public class LsCommand
{
    public void ls(string[] newArgs)
    {
        //Set the different values
        string path = Environment.CurrentDirectory;
        var info = new DirectoryInfo(path);

        if (newArgs.Contains("-l")) // If the newArgs contains '-l' then will the program show alls files with more info
        {
            foreach (var file in info.GetFiles())
            {
                Console.WriteLine(
                    $"{file.Attributes}  {file.Length, 8}  {file.CreationTime:dd-MM.yyyy HH:mm}  {file.Name}"
                );
            }
        }
        else
        {
            foreach (var file in info.GetFiles())
            {
                Console.WriteLine(file.Name);
            }
        }
    }
}
