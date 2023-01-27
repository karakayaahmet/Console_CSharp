// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

DateTime simdi = DateTime.Now;
Console.WriteLine(simdi);
Console.WriteLine(simdi.Year);
Console.WriteLine(simdi.Month);
Console.WriteLine(simdi.Day);
Console.WriteLine(simdi.DayOfWeek);
Console.WriteLine(simdi.DayOfYear);

Console.WriteLine(simdi.Hour);
Console.WriteLine(simdi.Minute);
Console.WriteLine(simdi.Second);

DateTime dt = new DateTime(2018, 6, 30, 14, 43, 43);
Console.WriteLine(dt.AddDays(7));
Console.WriteLine(dt.AddHours(6));
Console.WriteLine(dt.AddYears(3));
Console.WriteLine(dt.AddMonths(6));

var fark = simdi - dt;

Console.WriteLine(fark.TotalDays);
Console.WriteLine(fark.TotalHours);
Console.WriteLine(fark.TotalMinutes);
Console.WriteLine(fark.TotalSeconds);

Console.WriteLine(simdi.ToString("d"));
Console.WriteLine(simdi.ToString("D"));

Console.WriteLine(simdi.ToString("F"));
Console.WriteLine(simdi.ToString("M"));

Console.WriteLine(simdi.ToString("t"));
Console.WriteLine(simdi.ToString("T"));

Console.WriteLine(simdi.ToString("Y"));
Console.WriteLine(simdi.ToShortDateString());

Console.WriteLine(simdi.ToString("hh:mm:ss"));
Console.WriteLine(simdi.ToString("ddd MMM %d, yyyy"));

