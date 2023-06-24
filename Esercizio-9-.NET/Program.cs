using Esercizio_9_.NET;

Console.WriteLine("Please enter the Celcius");
string input = Console.ReadLine(); 
double inp = int.Parse(input);  

ConversionToFahrenheit ctf = new ConversionToFahrenheit();
var convert = ctf.ConversionFahrenheit(inp);
Console.WriteLine(convert);

