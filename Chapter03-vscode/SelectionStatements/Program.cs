using static System.Console;

string password = "ninja";
if (password.Length < 8)
{
    WriteLine("Your password is too short. Use at least 8 characters.");
}
else
{
    WriteLine("Your password is strong.");
}


// add and remove the "" to change the behavior
object o = "3";
int j = 4;
if (o is int i)
{
    WriteLine($"{i} x {j} = {i * j}");
}
else
{
    WriteLine("o is not an int so it cannot multiply!");
}

int number = (new Random()).Next(1, 7);
WriteLine($"My random number is {number}");
switch (number)
{
    case 1:
        WriteLine("One");
        break; // jumps to end of switch statement
    case 2:
        WriteLine("Two");
        goto case 1;
    case 3: // multiple case section
    case 4:
        WriteLine("Three or four");
        goto case 1;
    case 5:
        goto A_label;
    default:
        WriteLine("Default");
        break;
} // end of switch statement
WriteLine("After end of switch");
A_label:
WriteLine($"After A_label");
