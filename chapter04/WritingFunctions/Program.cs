using System.Globalization;
using static System.Console;

TimesTable(6);

WriteLine("---------------------------------------");

decimal taxToPay = CalculateTax(amount: 301, twoLetterRegionCode: "TR");
WriteLine($"You must pay {taxToPay.ToString("C", new CultureInfo("en-US"))} in tax");

WriteLine("---------------------------------------");

RunCardinalToOrdianal(50);

WriteLine("---------------------------------------");

RunFactorial(13);

WriteLine("---------------------------------------");

RunFibImperative(30);

WriteLine("---------------------------------------");

RunFibFunctional(30);

// Byte türünden alınan değerin 12 sayısına kadar çarpım tablosunu veren fonksiyon.
static void TimesTable(byte number)
{
    WriteLine($"This is the {number} times table:");
    
    for(int row = 1; row <= 12; row++)
    {
        WriteLine($"{row} x {number} = {row * number}");
    }
}

// Harcanan değer ve lokasyon bilgisini alan ve vergi hesaplayan fonksiyon.
static decimal CalculateTax(decimal amount, string twoLetterRegionCode)
{
    decimal rate = 0.0M;    // Vergi oranı

    switch(twoLetterRegionCode)
    {
        case "CH":  // Switzerland
            rate = 0.08M;
            break;
        case "DK":  // Denmark 
        case "NO":  // Norway
            rate = 0.25M;
            break;
        case "GB":  // United Kingdom
        case "FR":  // France
            rate = 0.2M;
            break;
        case "HU":  // Hungray
        case "TR":  // Turkey
            rate = 0.27M;
            break;
        case "OR":  // Oregon
        case "AK":  // Alaska
        case "MT":  // Montana
            rate = 0.0M;
            break;
        case "ND":  // North Dakota
        case "WI":  // Wisconsin
        case "ME":  // Maine
        case "VA":  // Virginia
            rate = 0.05M;
            break;
        case "CA":  // California
            rate = 0.0825M;
            break;
        default:    // Most US States
            rate = 0.06M;
            break;
    }

    return (rate * amount);
}

// Sıra sayılarını yazdıran fonksiyon.
/*
>>> limit sayısına gelene kadar sayıları ',' ile ayır.
>>> her 10 sayıda bir paragraf başı yap.
*/
static void RunCardinalToOrdianal(int limitNumber)
{
    for(int number = 1; number <= limitNumber; number++)
    {
        Write($"{CardinalToOrdinal(number)}");

        if(number < limitNumber)
        {
            Write(", ");
        }

        if(number % 10 == 0)
        {
            WriteLine();
        }
    }
}

// Rekürsif faktoriyel hesaplayan fonksiyon.
/*
>>> gelen sayı 0'dan küçük ise bir hata mesajı fırlat.
>>> gelen sayı int sınırları dışına çıkarsa diye 'checked' ile kontrol et.
*/
static int FactorialRecursive(int number)
{
    if(number < 0)
    {
        throw new ArgumentException(
            message: $"factorial function not expect a negative value. Input: {number}",
            paramName: nameof(number)
        );
    }

    else if(number == 1 || number == 0)
    {
        return 1;
    }

    else
    {
        checked
        {
            return (number * FactorialRecursive(number -1));
        }
    }
}

// Gönderilen sınır değerine kadar sayıların faktoriyelini alan fonksiyon.
/*
>>> sınır taşması veya başka bir hata meydana gelirse yazdır.
*/
static void RunFactorial(int limitNumber)
{
    for(int number = -2; number <= limitNumber; number++)
    {
        try
        {
            WriteLine($"{number}! = {FactorialRecursive(number):N0}");
        }
        catch(System.OverflowException)
        {
            WriteLine($"{number}! is too big for a 32-bit integer");
        }
        catch(Exception ex)
        {
            WriteLine($"{ex.GetType()}: {ex.Message}");
        }
    }
}

// alınan parametre değerinin fibonnaci serisinde karşılığını veren rekürsif fonkiyon.
// İmperative
// lambda function
static int FibImperativeRecursive(int term)
{
    if(term == 1)
    {
        return 0;
    }

    else if(term == 2)
    {
        return 1;
    }

    else
    {
        return (FibImperativeRecursive(term - 1) + FibImperativeRecursive(term - 2));
    }

}

// Gönderilen sınır değerine kadar sayıların fibonnaci serisinde karşılığını veren fonksiyon.
static void RunFibImperative(int limitNumber)
{
    for(int i = 1; i <= limitNumber; i++)
    {
        WriteLine("The {0} term of the Fibonnaci sequence is {1:N0}",
            arg0:CardinalToOrdinal(i),
            arg1:FibImperativeRecursive(i)
        );
    }
}

// alınan parametre değerinin fibonnaci serisinde karşılığını veren rekürsif fonkiyon.
// Declarative
static int FibFunctional(int term) =>
    term switch
    {
        1 => 0,
        2 => 1,
        _ => FibFunctional(term -1) + FibFunctional(term - 2)
    };

// Gönderilen sınır değerine kadar sayıların fibonnaci serisinde karşılığını veren fonksiyon.
static void RunFibFunctional(int limitNumber)
{
    for(int i = 1; i <= limitNumber; i++)
    {
        WriteLine("The {0} term of the Fibonnaci sequence is {1:N0}",
            arg0:CardinalToOrdinal(i),
            arg1:FibImperativeRecursive(term: i)
        );
    }
}
partial class Program
{
    /// <summary>
    /// Sıra sayılarının önüne "ek" koyan fonksiyon.
    /// gelen sayı 11,12,13 değerlerinden biri ise istisnadır ve 'st' ön eki ile döndür.
    /// gelen sayı 11,12,13 değerlerinden biri değilse 10 ile bölümünden 
    /// kalana göre 'st','nd','rd','th' ön eklerinden biri ile döndür.
    /// </summary>
    /// <param name="number">örn:1, 2, 3, 4, vs...</param>
    /// <returns>örn:1st, 2nd, 3rd, 4th .vs</returns>
    static string CardinalToOrdinal(int number)
    {
        switch(number)
        {
            case 11:
            case 12:
            case 13:
                return $"{number}st";
            default:
                int lastDigit = number % 10;
                string suffix = lastDigit switch
                {
                    1 => "st",
                    2 => "nd",
                    3 => "rd",
                    _ => "th"
                };
                return $"{number}{suffix}";
        }
    }
}