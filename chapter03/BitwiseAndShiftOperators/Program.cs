using static System.Console;

// Not: Bitwise operatörleri bitler üzerinde çalışır.
// Bitwise operatörleri
int a = 10; // 0000 1010 (2^1 + 2^3);
int b = 6;  // 0000 0110 (2^1 + 2^2);

WriteLine($"a = {a}");
WriteLine($"b = {a}");
WriteLine($"a & b = {a & b}");  // 0000 0010
WriteLine($"a | b = {a | b}");  // 0000 1110
WriteLine($"a ^ b = {a ^ b}");  // 0000 1100

// Not: Bir sayıyının bitlerini sola kaydırmak demek her kaydırmada sayıyı 2 ile çarpmaktır.
// Not: Bir sayıyının bitlerini sağa kaydırmak demek her kaydırmada sayıyı 2 ile bölmektir.
// Son Not: bit üzerinde işlem yapmak CPU açısından daha performanslıdır ama bu her zaman bitwise ile işlem yap demek değil.
WriteLine($"a << 3 = {a << 3}"); // 0101 0000
WriteLine($"a * 8 =  {a * 8}");
WriteLine($"b >> 1 = {b >> 1}"); // 0000 0011
WriteLine();

// Gelen değeri binary'e dönüştür ve PadLeft fonksiyonu ile 8 karakter uzunluğunda olmasını sağla.
static string ToBinaryString(int value)
{
    return Convert.ToString(value, toBase: 2).PadLeft(8, '0');
}

WriteLine("Outputting integers as binary:");
WriteLine($"a     = {ToBinaryString(a)}");
WriteLine($"b     = {ToBinaryString(b)}");
WriteLine($"a & b = {ToBinaryString(a & b)}");
WriteLine($"a | b = {ToBinaryString(a | b)}");
WriteLine($"a ^ b = {ToBinaryString(a ^ b)}");