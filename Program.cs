using System.IO;
using System.Collections.Generic;

IEnumerable<string> FindFiles(string folderName)
{
    List<string> salesFiles = new List<string>();

    var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

    foreach (var currentFile in foundFiles)
    {
        if (currentFile.EndsWith("sales.json"))
        {
            salesFiles.Add(currentFile);
        }
    }

    return salesFiles;
}

var salesFiles = FindFiles("stores");

foreach (var file in salesFiles)
{
    Console.WriteLine(file);
}