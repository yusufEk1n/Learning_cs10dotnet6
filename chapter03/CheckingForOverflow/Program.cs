using static System.Console;

// checked anahtar kelimesini kullanarak runtime'da overflow durumlarını tespit etmek. 
try
{
    checked
    {
        int x = int.MaxValue - 1;
        WriteLine($"Initial value: {x}");
        x++;
        WriteLine($"After incrementing: {x}");
        x++;
        WriteLine($"After incrementing: {x}");
        x++;
        WriteLine($"After incrementing: {x}");
    }
}
catch(OverflowException)
{
    WriteLine("The code overflowed but ı caught the exception.");
}

WriteLine("--------------------------------------------");

// unchecked anahtar kelimesini kullanarak derleyicinin overflow durumlarını görmezden gelmesini sağlanır. 
unchecked
{
    int y = int.MaxValue + 1;
    WriteLine($"Initial value: {y}");
    y--;
    WriteLine($"After decrementing: {y}");
    y--;
    WriteLine($"After decrementing: {y}");
}
