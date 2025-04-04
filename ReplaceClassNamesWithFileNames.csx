using System;
using System.IO;

const string folderPath = @"C:\Users\dadaP\source\repos\Unofficial-xunit-documentation-v3-2-0-0\v3-2.0.0\src\xunit.v3.assert\Asserts";

foreach (string file in Directory.GetFiles(folderPath, "*.cs"))
{
  string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(file);
  string content = File.ReadAllText(file);

  // Replace class name
  string updatedFileContent = content.Replace("partial class Assert", $"class {fileNameWithoutExtension}");

  File.WriteAllText(file, updatedFileContent);
  Console.WriteLine($"Updated class name in {file}");
}