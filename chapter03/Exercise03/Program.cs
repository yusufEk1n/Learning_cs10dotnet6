for(int i = 1; i <= 100; i++)
{
    if(i % 3 == 0 && i % 5 == 0)
    {
        Console.Write("FizzBuzz");
    }
    else if(i % 5 == 0)
    {
        Console.Write("Buzz");
    }
    else if(i % 3 == 0)
    {
        Console.Write("Fizz");
    }
    else
    {
        Console.Write($"{i}");
    }

    // 100'den önceki tüm sayılardan sonra ',' koy.
    if(i < 100)
    {
        Console.Write(", ");
    }

    // Her 10 sayıda bir satır başı yap.
    if(i % 10 == 0)
    {
        Console.WriteLine();
    }
}