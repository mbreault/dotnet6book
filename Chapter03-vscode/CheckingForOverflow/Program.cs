using static System.Console;

try
{
    int x = int.MaxValue - 1;
    WriteLine($"Initial Value: {x}");
    x++;
    WriteLine($"After incrementing: {x}");
    x++;
    WriteLine($"After incrementing: {x}");
    x++;
    WriteLine($"After incrementing: {x}");
    x++;
    WriteLine($"After incrementing: {x}");
}
catch (OverflowException) {
    WriteLine("Caught an overflow exception.");
}