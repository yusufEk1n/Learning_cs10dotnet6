using static System.Console;

// Try-Catch kullanarak farklı hata durumlarıyla çalışmak.
WriteLine("Before parsing?");
Write("What is your age?: ");

string input = ReadLine();
try
{
    int age = int.Parse(input);
    WriteLine($"You are {age} years old.");
}
catch(OverflowException) // age aralık dışına çıkarsa OverFlowException hatası ver.
{
    WriteLine("Your age is a valid number format but it is either too big or small");
}
catch(FormatException)  // age sayı formatında değilse FormatException hatası ver.
{
    WriteLine("The age you entered not a valid number format.");
}
catch(Exception ex) // Genel hata durumu
{
    WriteLine($"{ex.GetType()} says {ex.Message}");
}

WriteLine("--------------------------------------------");

// istisna yakalmayı filterlemek.
Write("Enter an amount: ");
string amount = ReadLine();

try
{
    decimal amountValue = decimal.Parse(amount);
}
catch(FormatException) when (amount.Contains("$"))  // amount '$' işareti içeriyorsa FormatException hatası ver.
{
    WriteLine("The amount cannot use dollar sign!");
}
catch(FormatException)
{
    WriteLine("The amount must only contain digits!");
}