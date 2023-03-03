using System.Collections;
using static System.Console;

// While 
int x = 0;
while(x < 10)
{
    WriteLine(++x);
}

// Do while
string? password;
int errorCount = 1;

do
{
    if(errorCount > 10)
    {
        Console.WriteLine(errorCount);
        WriteLine("Your maximum logins allowance is full.");
        return;
    }

    Write("Enter the password: ");
    password = ReadLine();
    errorCount++;
} while(password != "abcd");

WriteLine("Correct");

// For
for(int i = 0; i < 10; i++)
{
    WriteLine(i);
}

// Foreach
string[] names = {"Yusuf", "Ali", "Veli"};

foreach(string name in names)
{
    WriteLine($"{name} has {name.Length} characters");
}

// How foreach works internally | read-only
IEnumerator e = names.GetEnumerator();

while(e.MoveNext())
{
    string name = (string)e.Current;
    WriteLine($"{name} has {name.Length} characters");
}