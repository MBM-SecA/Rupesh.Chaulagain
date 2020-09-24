using System.IO;
using System;

public class FileIO
{
    public void LearnFileHandling()
    {
        string filename="file.txt";
        if (File.Exists(filename))
        {
        string filecontent = File.ReadAllText("filename");
        Console.WriteLine(filecontent);
        }
        File.WriteAllText(filename, "Just a text file. pshh");
    }

    public void LearnFileInfo()
    {
        string filename ="file.txt";
        FileInfo fileinfo = new FileInfo(filename);
        var size = fileinfo.Length;
        var createddate=fileinfo.CreationTime;

        Console.WriteLine($"Filesize : {size} bytes");
    }
    public void LearnDirectory()
    {
        string directoryname= "A";
        Directory.CreateDirectory(directoryname);
    }
    
}
