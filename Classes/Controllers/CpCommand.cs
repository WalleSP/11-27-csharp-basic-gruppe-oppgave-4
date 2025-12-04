using System.Diagnostics;
using Spectre.Console;

namespace _11_27_csharp_basic_gruppe_oppgave_4;

public class CpCommand
{
    public static void cp(string newArgs, string sourceName, string destName) // Gets the different info by the user
    {
        var finalDest = destName;

        if (newArgs.Contains("-r")) // If newArgs constains '-r' the program knows that the user wants to copy an directory
        {
            var dir = new DirectoryInfo(sourceName);

            if (!dir.Exists) // Checks if directory exist
            {
                Console.WriteLine($"'{sourceName}' dont found");
                return;
            }

            if (Directory.Exists(destName)) // If the directory exsist its combines the destination path and direcotry info to finalDest
            {
                finalDest = Path.Combine(destName, dir.Name);
            }

            Directory.CreateDirectory(finalDest); // Create the new directory

            foreach (FileInfo file in dir.GetFiles()) // Copy all the files in old directory into the new one
            {
                string targetFilePath = Path.Combine(finalDest, file.Name);
                file.CopyTo(targetFilePath, true);
                Console.WriteLine($"Directory '{sourceName}' copied to '{finalDest}'");
            }
        }
        else
        {
            if (File.Exists(sourceName)) // If it doesn't have '-r' then the program knows the user wants to copy an file
            {
                if (Directory.Exists(destName)) // Checks if the destination directory exist and copy the file into it
                {
                    string destFile = Path.Combine(destName, Path.GetFileName(sourceName));
                    File.Copy(sourceName, destFile, true);
                    Console.WriteLine($"File '{sourceName}' copied to '{finalDest}'");
                }
                else // If the directory dont exist, the program thinks the user just want to copy file in the same directory
                {
                    File.Copy(sourceName, destName, true);
                    Console.WriteLine($"File '{sourceName}' copied to '{finalDest}'");
                }
            }
        }
    }
}
