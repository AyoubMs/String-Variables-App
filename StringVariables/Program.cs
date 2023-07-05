

string firstName = string.Empty;
string lastName = string.Empty;
string filePath = string.Empty;

// expertsExchange
// expert sex change

firstName = "Tim";
lastName = "Corey";
//filePath = "C:\\Temp\\Demo";
filePath = @"C:\Temp\Demo";
//firstName = "123";


//Console.WriteLine(firstName + " " + lastName);

string testString = $@"The file for {firstName} is at {filePath}";

// String interpolation
Console.WriteLine($"Hello {firstName} {lastName}");
Console.WriteLine(filePath);
Console.WriteLine(testString);

