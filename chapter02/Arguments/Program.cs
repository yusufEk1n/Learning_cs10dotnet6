using static System.Console;

WriteLine($"There are {args.Length} arguments");


foreach(string arg in args)
{
    WriteLine($"{arg, -10} passed as argument in consol app.");
}


// Kullanıcı yeterli argüman girdi mi?
if(args.Length < 3)
{
    WriteLine("You must enter two color and cursor size, e.g");
    WriteLine("dotnet run red yellow 50");
    return;
}

BackgroundColor = (ConsoleColor)Enum.Parse(
    enumType: typeof(ConsoleColor),
    value: args[1],
    ignoreCase: true
);

ForegroundColor = (ConsoleColor)Enum.Parse(
    enumType: typeof(ConsoleColor),
    value: args[0],
    ignoreCase: true
);

try
{
    CursorSize = int.Parse(args[2]);
}
catch(PlatformNotSupportedException)
{
    WriteLine("The current platform does not supoort changing the size of the cursor.");
}

//Farklı platformlarda çalıştırma
if(OperatingSystem.IsWindows())
{
    WriteLine("works on windows");
}

else if(OperatingSystem.IsWindowsVersionAtLeast(major: 10))
{
    WriteLine("works on windows 10 or later");
}

else if(OperatingSystem.IsIOSVersionAtLeast(major: 14, minor: 5))
{
    WriteLine("works on IOS 14.5 or later");
}

else if(OperatingSystem.IsBrowser())
{
    WriteLine("works on browser with blazor");
}

// preprocessor directives kullanarak farklı platformlarda çalıştırma
#if NET6_0_ANDROID
    writline("works on Android");
#elif NET6_0_IOS
    WriteLine("works on IOS");
#else
    WriteLine("works everywhere");
#endif

// Dummy text ile test edelim.
string dummyText = 
$@"
Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed in dictum urna. Vestibulum euismod urna ac nisl vestibulum efficitur. 
In at viverra magna. Aenean id laoreet lorem. Praesent semper ullamcorper nisl, vel sollicitudin enim scelerisque nec. 
Morbi tincidunt urna mattis libero consequat, eget faucibus dolor ultrices. Proin sed vestibulum sapien.
Aliquam molestie eu sem eleifend luctus.
";

WriteLine(dummyText);