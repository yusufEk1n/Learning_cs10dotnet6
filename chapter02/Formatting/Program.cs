using static System.Console;

int numberOfApples = 12;
decimal pricePerApple = 0.35M;

// Numbered positional arguments
Console.WriteLine(
    format: "{0} apples costs {1:C}",
    arg0: numberOfApples,
    arg1: numberOfApples * pricePerApple
);

// string formatted with method
string formatted = string.Format(
    format: "{0} apples costs {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples
);

Console.WriteLine(formatted);

// Interpolated string
Console.WriteLine($"{numberOfApples} apples costs {pricePerApple * numberOfApples:C}\n");


// String verilerini sağa-sola hizalayarak formatlamak.
// Negatif değerler ile sağa, pozitif değerler ile sola hizalanır.
string applesText = "Apples";
int applesCount = 1234;

string bananaText = "Banana";
int bananaCount = 5678;

Console.WriteLine(
    format: "{0, -10} {1,6:N0}",
    arg0: "Name",
    arg1: "Count"
);

Console.WriteLine(
    format: "{0, -10} {1,6:N0}",
    arg0: applesText,
    arg1: applesCount
);

Console.WriteLine(
    format: "{0, -10} {1,6:N0}",
    arg0: bananaText,
    arg1: bananaCount
);


// Input almak
Console.Write("Type your first name and press ENTER: ");
string? firstName = Console.ReadLine();

Console.Write("Type your age and press ENTER: ");
string? age = Console.ReadLine();

Console.WriteLine($"Hello {firstName} you look good for {age}");


// Key input almak
Write("Press any key combination: ");
ConsoleKeyInfo key = ReadKey();
WriteLine();
WriteLine("Key: {0}, Char: {1}, Modifiers: {2}",
    arg0: key.Key,
    arg1: key.KeyChar,
    arg2: key.Modifiers
);