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

var salesTotalDir = Path.Combine(currentDirectory, "salesTotalDir");
Directory.CreateDirectory(salesTotalDir); // creates the directory if it doesn't exist

var salesFiles = FindFiles(storesDirectory);

File.WriteAllText(Path.Combine(salesTotalDir, "totals.txt"), String.Empty); 

