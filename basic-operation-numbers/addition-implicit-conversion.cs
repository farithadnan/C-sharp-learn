// Add two numeric value
int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber); 
//output: 19

// Add Mix data type  (implicit conversion between string and int)
// - c# convert int to string for concatenation 
string firstName = "Bob";
int widgetsSold = 7;

Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");
// output: Bob sold 7 widgets.

Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");
// output: Bob sold 77 widgets.

Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");
// output: Bob sold 14 widgets.