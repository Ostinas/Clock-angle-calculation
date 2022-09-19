using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Transactions;

Console.WriteLine("Please input your desired hours (in 24h format): ");
var Hour = Console.ReadLine();
Console.WriteLine("Please input your desired minutes: ");
var Minute = Console.ReadLine();
if (int.Parse(Hour) > 24 || int.Parse(Hour) < 1 || int.Parse(Minute) > 60 || int.Parse(Minute) < 1)
{
    Console.WriteLine("Please input number 1-24 for the hours or 1-60 for the minutes!");
    Thread.Sleep(5000);
    Environment.Exit(0);
}
Console.WriteLine("The time that you have chosen: {0}:{1}", Hour, Minute);

int Hours = int.Parse(Hour);
int Minutes = int.Parse(Minute);
// minute arrow moves by 6 degrees each minute (360 / 60)
int MinuteAngleChange = 6;
// Hour arrow moves by 30 degrees each hour (360 / 12) or 0.5 degrees each minute
int HourAngleChange = 30;
double HourAngleChangeByMinute = 0.5;

int MinsAngle = MinuteAngleChange * Minutes;
double HrsAngle = Hours * HourAngleChange + Minutes * HourAngleChangeByMinute;

double Angle = HrsAngle - MinsAngle;
switch (Angle)
{
    case > 180.0:
        Console.WriteLine("The lesser angle between the arrows is: {0} degrees", 360 - Angle);
        break;
    case <= 180.0:
        Console.WriteLine("The lesser angle between the arrows is: {0} degrees", Angle);
        break;
    default:
        Console.WriteLine("The angles between both sides of the arrows are equal");
        break;
}