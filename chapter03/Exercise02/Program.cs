int max = 500;

try
{
    checked
    {
        for(byte i = 0; i < max; i++)
        {
           Console.WriteLine(i);
        }    
    }
}
catch(OverflowException ex)
{
    Console.WriteLine($"'{ex.Message}' exception was occured.");
}
