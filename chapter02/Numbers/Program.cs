// unsigned integer: pozitif tam sayılar sıfır(0) dahil.
uint naturalNumber = 23;

// Pozitif ve negatif tüm tam sayılar.
int integerNumber = -23;

// float tek duyarlılıklı virgülü sayı anlamına gelir.
// F soneki ile kullanılır.
float realNumber = 2.3F;

// Double çift duyarlılıklı virgülü sayı anlamına gelir.
double anotherRealNumbers = 2.3;


// 2 milyon sayısının üç farklı şekilde gösterimi.
int decimalNotation = 2_000_000;
int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
int hexadecimalNotation = 0x_001E_8480;

// üç sayının aynı olduğunun kontrolü.
Console.WriteLine($"{decimalNotation == hexadecimalNotation}\n" +  
                  $"{decimalNotation == hexadecimalNotation}");


// Bazı tiplerin boyutları ve değer aralıkları.
Console.WriteLine("\nFor int\n----------------------------");
Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in " + 
                  $"the range {int.MinValue:N0} to {int.MaxValue:N0}.");

Console.WriteLine("\nFor float\n----------------------------");
Console.WriteLine($"float uses {sizeof(float)} bytes and can store numbers in " + 
                  $"the range {float.MinValue:N0} to {float.MaxValue:N0}.");

Console.WriteLine("\nFor double\n----------------------------");
Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in " + 
                  $"the range {double.MinValue:N0} to {double.MaxValue:N0}.");

Console.WriteLine("\nFor decimal\n----------------------------");
Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in " + 
                  $"the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}.");


// double değerlerin karşılaştırılması.
// not: double değerlerde virgülden sonra değer kaybı ihtimali olduğundan,
//      double değerler ile karşılaştırma yapmak hataya neden olur.
//      bunun yerine aralık belirten karşılaştırmalar kullanılabilir.

Console.WriteLine("using doubles:");
double a = 0.1;
double b = 0.2;

if(a + b == 0.3)
{
    Console.WriteLine($"{a} + {b} equals {0.3}");
}
else
{
    Console.WriteLine($"{a} + {b} not equals {0.3}");
}

// ondalıklı sayılar ile karşılaştırma yapılacaksa decimal kullanılmalıdır.
Console.WriteLine("using decimal:");
decimal c = 0.1M; // M suffix
decimal d = 0.2M;

if(c + d == 0.3M)
{
    Console.WriteLine($"{a} + {b} equals {0.3}");
}
else
{
    Console.WriteLine($"{a} + {b} not equals {0.3}");
}