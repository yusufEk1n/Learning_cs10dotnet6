using static System.Console;

try
{
    Write("Enter a number between 0 and 255: ");
    byte firstNumber = byte.Parse(ReadLine());
    
    Write("Enter another number between 0 and 255: ");
    byte secondNumber = byte.Parse(ReadLine());

    int answer = firstNumber / secondNumber;

    WriteLine($"{firstNumber} divide by {secondNumber} is {answer}");
}
catch(Exception ex)
{
    WriteLine($"{ex.GetType()}: {ex.Message}");
}