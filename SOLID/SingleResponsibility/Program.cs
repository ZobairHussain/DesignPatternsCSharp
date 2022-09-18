using System.Diagnostics;

var j = new Journal();
j.AddEntry("I cried today.");
j.AddEntry("I ate a bug.");
Console.WriteLine(j);

var p = new Persistence();
var filename = @"c:\temp\journal.txt";
p.SaveToFile(j, filename);
Process.Start(filename);