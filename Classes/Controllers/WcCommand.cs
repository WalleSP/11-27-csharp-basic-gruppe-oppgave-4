using System;
using System.IO;

public class WcCommand
{
    public void Wc(string filePath)
    {
        if (File.Exists(filePath))
        {
            string content = File.ReadAllText(filePath);
            
            // Count lines
            int lines = File.ReadAllLines(filePath).Length;
            
            // Count words (split by whitespace)
            int words = content.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
            
            // Count bytes
            long bytes = new FileInfo(filePath).Length;

            // Output format: lines words bytes filename
            Console.WriteLine($"\t{lines}\t{words}\t{bytes}\t{filePath}");
        }
        else
        {
            Console.WriteLine($"wc: {filePath}: No such file or directory");
        }
    }
}