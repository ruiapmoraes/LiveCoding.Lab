using LiveCoding.Lab.Core.Exercises.Arrays;
using LiveCoding.Lab.Core.Exercises.StackQueue;
using LiveCoding.Lab.Core.Exercises.Strings;

//// Exercise: Remove Vowels from a String
//var text = "Hello, Live Coding Lab!";
//Console.WriteLine($"Original input: {text}");
//var result = RemoveVowels.Execute(text);
//Console.WriteLine($"Result after removing vowels: {result}");

//// Exercise: Reverse a String

Console.OutputEncoding = System.Text.Encoding.UTF8;

var demos = new Dictionary<int, (string Title, Action Run)>
{
    {1, ("Strings: RemoveVowels", Demo_RemoveVowels) },
    {2, ("Strings: ReverString", Demo_ReverseString) },
    {3, ("Strings: PalindromeCheck", Demo_PalindromeCheck) },
    {4, ("Arrays: TwoSum", Demo_TwoSum) },
    {5, ("Stack/Queue: ValidParentheses", Demo_ValidParentheses) },
};

static void Demo_ReverseString()
{
    var input = "Hello Rui, live coding is training";
    var output = ReverseString.Execute(input);

    Console.WriteLine($"Input: {input}");
    Console.WriteLine($"Output: {output}");
}

static void Demo_RemoveVowels()
{
    var input = "Hello Rui, live coding is training";
    var output = RemoveVowels.Execute(input);

    Console.WriteLine($"Input: {input}");
    Console.WriteLine($"Output: {output}");
}

static void Demo_PalindromeCheck()
{
    var input = "A man a plan a canal Panama";
    var result = PalindromeCheck.Execute(input);

    Console.WriteLine($"Input: {input}.");
    Console.WriteLine($"Result: {result}.");
}

static void Demo_TwoSum() 
{
    var numbers = new[] { 2, 7, 11, 15 };
    var target = 9;

    var result = TwoSum.Execute(numbers, target);

    Console.WriteLine($"Numbers : [{string.Join(", ", numbers)}]");
    Console.WriteLine($"Target  : {target}");
    Console.WriteLine($"Result  : [{string.Join(", ", result)}]");
}

static void Demo_ValidParentheses() 
{
    var inputs = new[] 
    {
        "{[()]}",
        "{[(])}",
        "((()))",
        "(",
        ""
    };

    foreach (var input in inputs) 
    {
        var result = ValidParentheses.Execute(input);
        Console.WriteLine($"Input: {input,-10} -> {result}");
    }
}

while (true)
{
    Console.Clear();
    WriteHeader();

    foreach (var (key, value) in demos.OrderBy(x => x.Key))
        Console.WriteLine($"{key}. {value.Title}");

    Console.WriteLine("0. Exit");
    Console.WriteLine();

    Console.Write("Choose an option: ");
    var input = Console.ReadLine();

    if (!int.TryParse(input, out var option))
    {
        PauseWithMessage("Invalid input. Please enter a number.");
        continue;
    }

    if (option == 0)
        break;

    if (!demos.TryGetValue(option, out var demo))
    {
        PauseWithMessage("Option not found.");
        continue;
    }

    Console.Clear();
    WriteHeader();
    Console.WriteLine($"Executando: {demo.Title}");
    Console.WriteLine(new string('-', 50));

    try
    {
        demo.Run();
        Console.WriteLine();
        Console.WriteLine("OK ✅");
    }
    catch (Exception ex)
    {
        Console.WriteLine();
        Console.WriteLine($"Erro ❌: {ex.Message}");
    }

    Console.WriteLine();
    Console.Write("Press ENTER to return to menu...");
    Console.ReadLine();
}

static void WriteHeader()
{
    Console.WriteLine(new string('=', 46));
    Console.WriteLine(" LiveCoding.Lab - Exercise Runner");
    Console.WriteLine(new string('=', 46));
    Console.WriteLine();
}

static void PauseWithMessage(string msg)
{
    Console.WriteLine();
    Console.WriteLine(msg);
    Console.WriteLine();
    Console.Write("Pressione ENTER para continuar...");
    Console.ReadLine();
}

