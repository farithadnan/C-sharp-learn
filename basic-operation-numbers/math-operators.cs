int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;

// ways to deal with division
decimal quotient = 7.0m / 5;
decimal quotient2 = (decimal)7 / (decimal)5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);
Console.WriteLine("Quotient2: " + quotient2);
Console.WriteLine("Modulus of 7 / 5 : " + (7 % 5));


// ?: nullable types
int? nullableInt = null;

// ?: ternary conditional operator
// if temp less than 20, it's cold, else it's perfect
string GetWeatherDisplay(double tempInCelsius) => tempInCelsius < 20.0 ? "Cold." : "Perfect!";

Console.WriteLine(GetWeatherDisplay(15));  // output: Cold.
Console.WriteLine(GetWeatherDisplay(27));  // output: Perfect!

// ?? null coalescing operator
// returns the value of its left-hand operand if it isn't null; otherwise, it evaluates the right-hand operand and returns its result
int bornYear = 1997;
int result = bornyear ?? bornYear + 1;

// ??= null coalescing assignment operator
// if the left-hand operand is null, it assigns the value of the right-hand operand to the left-hand operand
List<int> numbers = null;

(numbers ??= new List<int>()).Add(5);
Console.WriteLine(string.Join(" ", numbers));  // output: 5
