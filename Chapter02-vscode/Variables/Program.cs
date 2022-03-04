using System.Xml;

object height = 1.88; // storing a double in an object 
object name = "Amir"; // storing a string in an object
Console.WriteLine($"{name} is {height} metres tall.");
//int length1 = name.Length; // gives compile error!
int length2 = ((string)name).Length; // tell compiler it is a string
Console.WriteLine($"{name} has {length2} characters.");
var population = 66_000_000; // 66 million in UK
var weight = 1.88; // in kilograms
var price = 4.99M; // in pounds sterling
var fruit = "Apples"; // strings use double-quotes
var letter = 'Z'; // chars use single-quotes
bool happy = true; // Booleans have value of true or false

// good use of var because it avoids the repeated type
// as shown in the more verbose second statement
var xml1 = new XmlDocument(); 
XmlDocument xml2 = new XmlDocument();
// bad use of var because we cannot tell the type, so we
// should use a specific type declaration as shown in
// the second statement
var file1 = File.CreateText("something1.txt"); 
StreamWriter file2 = File.CreateText("something2.txt");

XmlDocument xml3 = new(); // target-typed new in C# 9 or later

Person kim = new();
kim.BirthDate = new(1967, 12, 26); // instead of: new DateTime(1967, 12, 26)
Console.WriteLine(kim);
Console.WriteLine(kim.BirthDate);