string firstFriend = "Bill";
string secondFriend = "Maira";
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}\n");

// Length of a string

Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.\n");

// Trailing spaces

string greeting = "     Hello World!     ";
Console.WriteLine($"[{greeting}]");

string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]\n");

// Replace

string sayHello = "Hello World!";
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hello", "Greetings");
Console.WriteLine(sayHello);
Console.WriteLine();

// ToUpper and ToLower

Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());
Console.WriteLine();
