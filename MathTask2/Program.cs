
int time = 8;
int day = 6;
int month = 3;
int year = 2022;



if (time > 0 && time < 12)
{
    Console.WriteLine("Good Morning, Sunshine!");
}
else if (time >= 13 && time <= 19)
{
    Console.WriteLine("Good Afternoon. Work Hard!");
}
else if (time >= 20 && time <= 24)
{
    Console.WriteLine("Good Evening. Get some rest!");
}
else
{
    Console.WriteLine("Please, enter a valid time variable");
}


if (day <= 0 || day >= 32)
{
    Console.WriteLine("Please, enter a valid day variable!");
}
else if (month <= 0 || month > 12)
{
    Console.WriteLine("Please, enter a valid month variable!");
    return;
}
else if (year <= 0)
{
    Console.WriteLine("Please, enter a valid year variable!");
    return;
}
else
{
    Console.WriteLine(year.ToString()  + "/" + month.ToString("d2") + "/" + day.ToString("d2"));
}


Console.WriteLine("Please, enter the day value:");
var input = Console.ReadLine();
var day2 = int.Parse(input);

Console.WriteLine("Please, enter the month value:");
input = Console.ReadLine();
var month2 = int.Parse(input);

Console.WriteLine("Please, enter the year value:");
input = Console.ReadLine();
var year2 = int.Parse(input);

Console.WriteLine("Please, select the date format: 1 for YYYY/MM/DD, 2 for DD.MM.YYYY");
input = Console.ReadLine();

if (input == "1")
{
    Console.WriteLine(year2.ToString() + "/" + month2.ToString("d2") + "/" + day2.ToString("d2"));
}
else if (input == "2")
{
    Console.WriteLine(day2.ToString("d2") + "." + month2.ToString("d2") + "." + year2.ToString());
}