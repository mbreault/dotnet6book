using static System.Console;

int thisCannotBeNull  = 4; 
//thisCannotBeNull = null; // compile error!
int? thisCouldBeNull = null; 
WriteLine(thisCouldBeNull); 
WriteLine(thisCouldBeNull.GetValueOrDefault());
thisCouldBeNull = 7; 
WriteLine(thisCouldBeNull); 
WriteLine(thisCouldBeNull.GetValueOrDefault());


Address address = new();
address.Building = null;
address.Street = null;
address.City = "London";
address.Region = null;