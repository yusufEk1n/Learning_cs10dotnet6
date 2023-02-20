using System.Reflection;

//System.Data ve System.Net.Http DLL'lerinden gelen DataSet ve HttpClient tiplerinde kullanılmayan değişkenler tanımlandı.
System.Data.DataSet ds;
HttpClient client;

// Mevcut uygulamamıza ait assembly'den(Vocobulary.dll) bir nesne üret.
Assembly? assembly = Assembly.GetEntryAssembly();

if(assembly == null) return;

// Uygulamanın başvurduğu assemblies'leri al.
foreach(AssemblyName name in assembly.GetReferencedAssemblies())
{
    // Detayları okumak için Load fonksiyonuna parametre olarak gönder ve nesnesini oluştur.
    Assembly a = Assembly.Load(name);

    int methodCount = 0;

    // Assembly içerisindeki tipleri döndür.
    foreach (TypeInfo t in a.DefinedTypes)
    {
        // Tipler içerisindeki metotların sayısını topla.
        methodCount += t.GetMethods().Count();
    }

    // Metotların ve tiplerin sayısını yazdır.
    Console.WriteLine(
        "{0:N0} types with {1:N0} methods in {2} assembly.",
        arg0: a.DefinedTypes.Count(),
        arg1: methodCount,
        arg2: name.Name
    );
}
