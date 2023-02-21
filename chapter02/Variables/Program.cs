using System.Xml;

object height = 1.70;   // objede double olarak tutulur.
object name = "Yusuf";  // objede string olarak tutulur.
Console.WriteLine($"{name} is {height} metres tall.");


// int length1 = name.Lenght    // Hata verir çünkü compiler name değişkeninin tipini bilmiyor.
int length2 = ((string)name).Length; // Explicit cast
Console.WriteLine($"{name} has {length2} characters.");


// dynamic keyword ile tanımlanan değişkenler explicit cast işlemine gerek kalmadan başka bir türe dönüştürülebilir.
// Bu türün sahip olduğu üyeler kullanılabilir. 
dynamic something = "Ekin";
Console.WriteLine($"Length is {something.Length} and type is {something.GetType()}");

/* Bu yorum satırı kaldırılsa hata verir çünkü int tipinin Lenght özelliği yoktur. */
// something = 12;
// Console.WriteLine($"Length is {something.Lenght}");

something = new[] {3, 5, 7};
Console.WriteLine($"Length is {something.Length} and type is {something.GetType()}");


// Local değişkenler oluşturmak.
int population = 85_000_000;
double weight = 1.88;
decimal price = 4.98M;
string fruit = "banana";
char letter = 'Z';
bool happy = true;

// var keyword ile local değişkenler oluşturmak.
var Mypopulation = 85_000_000;
var Myweight = 1.88;
var Myprice = 4.98M;
var Myfruit = "banana";
var Myletter = 'Z';
var Myhappy = true;


// var tipi ile nesne başlatmak.
var xml1 = new XmlDocument();   // tip biliniyor, var kullanmak kodu temiz tutar. 
XmlDocument xml2 = new XmlDocument();

var file1 = File.CreateText("something1.txt");
StreamWriter file2 = File.CreateText("something2.txt"); // tip bilinmiyor, sınıf adı kullanmak karmaşıklığı giderir.


XmlDocument xml3 = new();   // target-type new in C# 9 or later

Person kim = new();
kim.BirthDate = new(1996, 10, 10); // new DateTime(1996, 10, 10) yerine kullanıldı.


// Tiplerin default değerleri
Console.WriteLine($"default(int) = {default(int)}"); 
Console.WriteLine($"default(bool) = {default(bool)}"); 
Console.WriteLine($"default(DateTime) = {default(DateTime)}"); 
Console.WriteLine($"default(string) = {default(string)}"); 

int number = 13;
Console.WriteLine($"number has been set to: {number}");
number = default;
Console.WriteLine($"number has been reset to its default: {number}");


// Array
string[] names;
names = new string[4];  // memory allocating

names[0] = "Ali";
names[1] = "Veli";
names[2] = "Yusuf";
names[3] = "Ekin";

for(int i = 0; i < names.Length; i++) 
{
    Console.WriteLine(names[i]);
}


class Person
{
    public DateTime BirthDate;
}


