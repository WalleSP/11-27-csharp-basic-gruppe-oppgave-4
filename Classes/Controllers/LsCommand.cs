namespace _11_27_csharp_basic_gruppe_oppgave_4
{
    public class LsCommand
    {
        public void ls(string[] newArgs)
        {
            string path = Environment.CurrentDirectory;
            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                Console.WriteLine(Path.GetFileName(file));
            }
        }
    }
}
