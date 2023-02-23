int x = 5;
int y = 3;

int resultOfAdding = x + y;
int resultOfMultiplying = x * y;

// Önce artır & Sonra Artır
int postfixIncrement = x++;
int prefixIncrement = ++x;

Type typeOfInteger = typeof(int);   // System.Int32
int howManyBytesAnInteger = sizeof(int);    // 4 byte

Console.WriteLine(typeOfInteger);
Console.WriteLine(howManyBytesAnInteger);


// Prefix ve postfix farkı
int a = 3;
int b = ++a;
Console.WriteLine($"a is {a} and b is {b}");

int c = 3;
int d = c++;
Console.WriteLine($"c is {c} and d is {d}");

// Bazı artimetik işlemler
int e = 11;
int f = 3;
Console.WriteLine($"e is {e}, f is {f}");
Console.WriteLine($"e + f = {e + f}");      // e += f
Console.WriteLine($"e - f = {e - f}");      // e -= f
Console.WriteLine($"e * f = {e * f}");      // e *= f
Console.WriteLine($"e / f = {e / f}");      // e /= f
Console.WriteLine($"e % f = {e % f}");      // e %= f

// (float / int) sonucu real bir sayı üretir.
double g = 11.0;
Console.WriteLine($"g is {g:N1} and f is {f}");
Console.WriteLine($"g / f = {g / f}");

