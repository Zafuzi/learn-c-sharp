int a = 5;
int b = 6;

int c = a - b;

int check = 10;
bool myTest = c > check;

if (myTest)
{
	Console.WriteLine($"The answer is greater than {check} | c = {c}");
}
else
{
	Console.WriteLine($"The answer is less than {check} | c = {c}");
}