using static System.Console;
using System.Globalization;

CultureInfo globalization = CultureInfo.CurrentCulture; 
CultureInfo localization = CultureInfo.CurrentUICulture;
WriteLine("The current globalization culture is {0}: {1}",
    globalization.Name, globalization.DisplayName);

WriteLine("The current localization culture is {0}: {1}",
  localization.Name, localization.DisplayName);
WriteLine();
WriteLine("en-US: English (United States)"); 
WriteLine("da-DK: Danish (Denmark)"); 
WriteLine("fr-CA: French (Canada)"); 
Write("Enter an ISO culture code: ");  
string? newCulture = "en-GB"; // default to en-US
if (!string.IsNullOrEmpty(newCulture))
{
  CultureInfo ci = new(newCulture); 
  // change the current cultures
  CultureInfo.CurrentCulture = ci;
  CultureInfo.CurrentUICulture = ci;
}
WriteLine();
string? name = "Mike";
string? dob = "01/01/1970";
string? salary = "500000";
DateTime date = DateTime.Parse(dob);
int minutes = (int)DateTime.Today.Subtract(date).TotalMinutes; 
decimal earns = decimal.Parse(salary);
WriteLine(
  "{0} was born on a {1:dddd}, is {2:N0} minutes old, and earns {3:C}",
  name, date, minutes, earns);
