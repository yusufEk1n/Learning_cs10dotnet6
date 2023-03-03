using static System.Console;

string password = "ninja";

// Basit bir if ifadesi kontrolü
if(password.Length < 8)
{
    WriteLine("Your password is too short. Use at least 8 character");
}
else
{
    WriteLine("Your password is strong");
}

WriteLine("----------------------------------");

// is keyword
object o = 3;
int j = 4;

if(o is int i)  // tip kontrolü
{
    WriteLine($"{i} x {j} = {i * j}");
}
else
{
    WriteLine("cannot multiply with o because o not an int");
}

WriteLine("----------------------------------");

// Switch
int number = ((new Random()).Next(1, 7));
WriteLine($"Generated random number is : {number}");

// Not: goto anahtar sözcüğü potansiyel olarak hataya sebebiyet verebileceğinden kullanılması çok tercih edilmez.
// goto anahtar kelimesi bu örnekte switch mantığı anlaşılması için kullanıldı.
switch(number)
{
    case 1:
        WriteLine("One");
        break;  // yapıdan çık.
    case 2:
        WriteLine("Two");
        goto case 1;
    case 3: // birden fazla case
    case 4:
        WriteLine("Four");
        goto case 1;
    case 5:
        goto A_label;
    default:
        WriteLine("Default");
        break;
}
WriteLine("End of switch");
A_label:
WriteLine("After A_label");

WriteLine("----------------------------------");

/*
>>> Kullanıcı girdisine göre mevcut dizinde okuma veya yazma modunda dosya oluşturan program.
*/
// Programın çalıştığı dizin yolunu al.
string path = @$"{Directory.GetCurrentDirectory()}";

// Kullanıcıdan tuş girdisi al.
Write("Press R for Read-only or press W writeable: ");
ConsoleKeyInfo key = ReadKey();
WriteLine();

Stream? s;

// basılan tuş r ise okuma modunda file.txt oluşturan bir akış oluştur.
// basılan tuş w ise yazma modunda file.txt oluşturan bir akış oluştur.
// basılan tuş r veya w değil ise akışı null yap.
if(key.Key == ConsoleKey.R)
{
    s = File.Open(
        Path.Combine(path, "file.txt"),
        FileMode.OpenOrCreate,
        FileAccess.Read
    );
}
else if(key.Key == ConsoleKey.W)
{
    s = File.Open(
        Path.Combine(path, "file.txt"),
        FileMode.OpenOrCreate,
        FileAccess.Write
    );
}
else
{
    s = null;
}

string message;

switch(s)
{
    case FileStream writeableFile when s.CanWrite: // Mevcut dosya akışı yazılabilir ise bu durum çalışır.
        message = "The stream is writeable a file.";
        break;
    case FileStream readOnlyFile when s.CanRead:
        message = "The stream is readable a file.";
        break;
    case MemoryStream ms:
        message = "The stream is memory adress"; 
        break;
    default:
        message = "The stream is other type.";  
        break;
    case null:
        message = "The stream is null";
        break;
}

// C# 8 ile gelen basit switch syntax
/*
message = s switch
{
    FileStream writeableFile when s.CanWrite
        => "The stream is writeable a file.",
    FileStream readOnlyFile when s.CanRead
        => "The stream is readable a file.",
    MemoryStream memoryStream
        => "The stream is memory adress",
    null
        => "The stream is null",
    _
        => "The stream is other type."
};
*/
WriteLine(message);