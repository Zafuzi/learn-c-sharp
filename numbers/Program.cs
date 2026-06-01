double a = 42.1; // natural type
decimal b = 38.2m; // explicit type
decimal c = checked((decimal)a + b); // coerced type conversion

Console.WriteLine($"The answer is {c}");