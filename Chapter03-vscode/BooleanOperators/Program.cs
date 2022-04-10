using static System.Console;

bool a = true;
bool b = false;
WriteLine($"AND  | a     | b    ");
WriteLine($"a    | {a & a,-5} | {a & b,-5} ");
WriteLine($"b    | {b & a,-5} | {b & b,-5} ");
WriteLine();
WriteLine($"OR   | a     | b    ");
WriteLine($"a    | {a | a,-5} | {a | b,-5} ");
WriteLine($"b    | {b | a,-5} | {b | b,-5} ");
WriteLine();
WriteLine($"XOR  | a     | b    ");
WriteLine($"a    | {a ^ a,-5} | {a ^ b,-5} ");
WriteLine($"b    | {b ^ a,-5} | {b ^ b,-5} ");

/* logical AND.  Always evaluate both operands.*/
WriteLine();
WriteLine($"a & DoStuff() = {a & DoStuff()}"); 
WriteLine($"b & DoStuff() = {b & DoStuff()}");

/* Conditional logical AND. Evaluate the right-hand operand only if it's necessary.*/
WriteLine();
WriteLine($"a & DoStuff() = {a && DoStuff()}"); 
WriteLine($"b & DoStuff() = {b && DoStuff()}");

static bool DoStuff()
{
  WriteLine("I am doing some stuff.");
  return true;
}
