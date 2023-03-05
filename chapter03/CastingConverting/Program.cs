using static System.Console;
using static System.Convert;

// İmplicit casting
int a = 10;
double b = a;   // bir int değişkeni double değişkenine güvenli bir şekilde dönüştürülebilir.
WriteLine(b);

// Explicit casting
double c = 9.8;
// int d = c;   // derleme hatası - double'dan integer'a dönüştürürken dikkatli olunmalıdır.
int d = (int)c;
WriteLine(d);   // 0.8 kaybedilir.

WriteLine("--------------------------------------------");

// Not: int kapasitesini (2147483647) aşan bir değer int'e dönüştürülmek istenirse, dönüştürülmek istenen sayının 
// int değişkenin maksimum değeri ile mod'u alınır ve çıkan sonuç atanır. 
long e = 10;
int f = (int)e;
WriteLine($"e is {e:N0} and f is {f:N0}");

e = 5_000_000_000;
f = (int)e; // e % int.maxValue
WriteLine($"e is {e:N0} and f is {f:N0}");

e = long.MaxValue;
f = (int)e; // Unspecified behavior
WriteLine($"e is {e:N0} and f is {f:N0}");

WriteLine("--------------------------------------------");

// Convert sınıfını kullanarak dönüştürme yapmak.
// Not: ToInt32 metodu decimal değeri int'e dönüştürürken virgülden sonraki basamak .5'den büyükse 
// kendinden büyük olan en küçük tamsayı değere, küçükse kendinden küçük olan en büyük tamsayı değere yuvarlar.
double g = 9.3;
int h = ToInt32(g); 
WriteLine($"g is {g} and h is {h}"); 

// Yuvarlama kuralını anlamak
double[] doubles = new[] { 9.49, 9.5, 9.51, 10.49, 10.5, 10.51 };

foreach(double n in doubles)
{
    WriteLine($"ToInt32({n}) is {ToInt32(n)}");
}

WriteLine("--------------------------------------------");

// Math.Round metodu ile yuvarlama kontrolü
foreach(double n in doubles)
{
    WriteLine(format:
        "Math.Round({0}, 0, MidpointRounding.AwayFromZero) is {1}",
        arg0: n,
        arg1: Math.Round(value: n,
                         digits: 0,
                         mode: MidpointRounding.AwayFromZero
        ));
}

WriteLine("--------------------------------------------");

// Not: object sınıfından kalıtım alan tüm sınıflar toString() metoduna sahiptir.
// Herhangi bir tipi string'e dönüştürmek.
int number = 12;
WriteLine($"number is {number.ToString()} and type is {number.ToString().GetType()}");

bool boolean = true;
WriteLine($"boolean is {boolean.ToString()} and type is {boolean.ToString().GetType()}");

DateTime now = DateTime.Now;
WriteLine($"now is {now.ToString()} and type is {now.ToString().GetType()}");

object me = new();
WriteLine($"me variable is {me.ToString()}");

WriteLine("--------------------------------------------");

/*
>>> Not: Video, resim gibi nesneleri bit olarak aktarmak istediğimizde işletim sistemleri
>>> veya ağ protokoleri tarafından yanlış yorumlanabilir. 
>>> Bitleri güvenli string karakterlerine dönüştürmek gerekir. Bu yönteme "Base64" denir. 
*/
// binary bir nesneyi string'e dönüştürmek.
byte[] binaryObject = new byte[128];

(new Random()).NextBytes(binaryObject); // bayt'ları random doldur

WriteLine("Binary object as byte: ");

for(int i = 0; i < binaryObject.Length; i++)
{
    Write($"{binaryObject[i]:X} ");    
}
WriteLine();

// base64'e dönüştür ve yazdır
string encoded = ToBase64String(binaryObject);

WriteLine($"Binary object as base64: {encoded}");

WriteLine("--------------------------------------------");

// Bir string dizesini tarih, zaman veya sayıya parse etmek.
int age = int.Parse("23");
DateTime birthday = DateTime.Parse("2000.01.01");

WriteLine($"I was born {age} years ago");
WriteLine($"My birthday is {birthday}");
WriteLine($"My birthday is {birthday:D}");

WriteLine("--------------------------------------------");

// Tryparse ile hatalardan kaçınmak.
Write("How many eggs are there?: ");
string? input = ReadLine();

if(int.TryParse(input, out int count))  // parse işlemi için referans bilinmelidir. Bu yüzden out keywordü ile geçilmelidir.
{
    WriteLine($"There are {count} eggs.");
}
else
{
    WriteLine("I could not parse the input");
}
