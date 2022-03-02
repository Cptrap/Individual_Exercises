// See https://aka.ms/new-console-template for more information
string NewLine()
{
    Console.WriteLine("\n");
    return "0";
   
}
//1
string name = "Asterios Vogiatzis";
string hi = "Hello ";
Console.WriteLine(String.Concat(hi, name));
NewLine();

//2
short i = 709;
short j = 634;
int sum = i + j;
float div = i / (float)j;
Console.WriteLine(sum);
Console.WriteLine(div);
NewLine();

//3
short result1 = (-1) + 5 * 6;
Console.WriteLine("result1 = "+result1);
short result2 = 38 + (5 % 7);
Console.WriteLine("result2 = "+result2);
float result3 = 14 + ((-3 * 6) / (float)7);
Console.WriteLine("result3 = " + result3);
double result4 = 2 + (13 / 6) * 6 + Math.Sqrt(7);
Console.WriteLine("result4 = "+result4);
double result5 = (Math.Pow(6, 4) + Math.Pow(5, 7)) / (9 % 4);
Console.WriteLine("result5 = " + result5);
NewLine();

//4
short age = 20;
string gender = "Female";
Console.WriteLine("You are " + gender + " and look younger than " + age);
NewLine();


//5
int seconds = 46857100;
int secs = seconds % 60;
int mins = (seconds / 60) % 60;
int hours = (seconds / 3600) % 24;
int days = ((seconds / 3600) / 24) - (((seconds / 3600) / 24) / 365) * 365;
int years = ((seconds / 3600) / 24) / 365;
string format = string.Format(
      "{0} years, {1} days, {2} hours, {3} minutes, {4} seconds",
       years, days, hours, mins, secs);
Console.WriteLine(format);
NewLine();



//6
TimeSpan time = TimeSpan.FromSeconds(seconds);
string formatted = string.Format(
      "{0} years, {1} days, {2} hours, {3} minutes, {4} seconds",
      time.Days / 365,
      (time.Days - (time.Days / 365) * 365) ,
      time.Hours,
      time.Minutes,
      time.Seconds);

Console.WriteLine(formatted);
NewLine();


//7
int tempraturecelsius = 50;
float fahrenheit = (tempraturecelsius * ((float)9 / 5) + 32);
Console.WriteLine("The temprature in kelvin: " + (tempraturecelsius + 273.15));
Console.WriteLine("The temprature in fahrenheit: " + fahrenheit);