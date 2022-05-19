// An overloaded method is defined with multiple method signatures. 
// Overloaded methods provide different ways to call the method or provide different types of data. 

Random dice = new Random();
int roll1 = dice.Next(); // no min and max param
int roll2 = dice.Next(101); // only max param
int roll3 = dice.Next(50, 101); // min and max param

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");

// output 
// First roll: 18796179
// Second roll: 75
// Third roll: 51