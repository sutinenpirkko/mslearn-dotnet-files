using System.IO;
using System.Collections.Generic;

IEnumerable<string> FindFiles(string folderName)
{
    List<string> salesFiles = new List<string>();

    var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

    foreach (var currentFile in foundFiles)
    {
        var extension = Path.GetExtension(currentFile);
        if (extension == ".json")
        {
            salesFiles.Add(currentFile);
        }
    }

    return salesFiles;
}

var currentDirectory = Directory.GetCurrentDirectory();
var storesDirectory = Path.Combine(currentDirectory, "stores");
var salesFiles = FindFiles(storesDirectory);

foreach (var file in salesFiles)
{
    Console.WriteLine(file);
}