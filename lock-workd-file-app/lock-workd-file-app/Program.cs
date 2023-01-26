// See https://aka.ms/new-console-template for more information


using GroupDocs.Merger;
using GroupDocs.Merger.Domain.Options;

Console.WriteLine("Path to the docx file: ");
string? path = Console.ReadLine();

Console.WriteLine("Password to encrypt: ");
string? pass = Console.ReadLine();

if (string.IsNullOrEmpty(path?.Trim()))
{
    Console.WriteLine("Path can not be null or empty");
    return;
}
 

if (string.IsNullOrEmpty(pass?.Trim()))
{
    Console.WriteLine("Password can not be null or empty");
    return;
}

var addOptions = new AddPasswordOptions(pass);

using Merger merger = new(path);

var fileName = Path.GetFileNameWithoutExtension(path);
var extension = Path.GetExtension(path);
var dir = Path.GetDirectoryName(path);

Console.WriteLine($"{dir}/{fileName}_encrypted{extension}");
merger.AddPassword(addOptions);
merger.Save($"{dir}/{fileName}_encrypted{extension}");

