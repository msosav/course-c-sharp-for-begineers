string songLyrics = "You say goodbye, and I say hello";

Console.WriteLine(songLyrics);
Console.WriteLine($"Contains goodbye: {songLyrics.Contains("goodbye")}");
Console.WriteLine($"Contains greetings: {songLyrics.Contains("greeetings")}");
Console.WriteLine($"Starts with You: {songLyrics.StartsWith("You")}");
Console.WriteLine($"Ends with hello: {songLyrics.EndsWith("hello")}");
Console.WriteLine($"Ends with goodbye: {songLyrics.EndsWith("goodbye")}");

