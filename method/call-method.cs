// create new instance of System.Random class..
// ..and stores the class reference to object variable called dice
Random dice = new Random();

// Next(min, max) to determine the range of random
int roll = dice.Next(1, 7);
Console.WriteLine(roll);

// Stateless Method (Static Method)
    // Method that dont rely on the current state of the papplication to work properly
    // For example, the Console.WriteLine() method doesn't rely on any values stored in memory. 
    // It performs its function and finishes without impacting the state of the application in any way.


// Stateful Method (instance method)
    // Method that rely on the current state of the application to work properly
    // For example, the Console.ReadLine() method relies on the state of the application to work properly. 
    // It performs its function and impacts the state of the application.
    // example: Random.Next(param1, param2)