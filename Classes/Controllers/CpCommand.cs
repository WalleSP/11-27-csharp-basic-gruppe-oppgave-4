using System.Diagnostics;
using Spectre.Console;

namespace _11_27_csharp_basic_gruppe_oppgave_4;

public class CpCommand
{
    public static void cp(string newArgs, string sourceName, string destName)
    {
        var finalDest = destName;

        if (newArgs.Contains("-r"))
        {
            var dir = new DirectoryInfo(sourceName);

            if (!dir.Exists)
            {
                Console.WriteLine($"'{sourceName}' dont found");
                return;
            }

            if (Directory.Exists(destName))
            {
                finalDest = Path.Combine(destName, dir.Name);
            }

            Directory.CreateDirectory(finalDest);

            foreach (FileInfo file in dir.GetFiles())
            {
                string targetFilePath = Path.Combine(finalDest, file.Name);
                file.CopyTo(targetFilePath, true);
                Console.WriteLine($"Directory '{sourceName}' copied to '{finalDest}'");
            }
        }
        else
        {
            if (File.Exists(sourceName))
            {
                if (Directory.Exists(destName))
                {
                    string destFile = Path.Combine(destName, Path.GetFileName(sourceName));
                    File.Copy(sourceName, destFile, true);
                    Console.WriteLine($"File '{sourceName}' copied to '{finalDest}'");
                }
                else
                {
                    File.Copy(sourceName, destName, true);
                    Console.WriteLine($"File '{sourceName}' copied to '{finalDest}'");
                }
            }
        }
    }
}
