using LiveCoding.Lab.Core.Exercises.Strings;

var text = "Hello, Live Coding Lab!";
Console.WriteLine($"Original input: {text}");
var result = RemoveVowels.Execute(text);
Console.WriteLine(result);