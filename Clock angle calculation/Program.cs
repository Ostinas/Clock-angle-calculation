using System.Transactions;

Console.WriteLine("Hello, please input your desired hours (in 24h format): ");
int Hours = int.Parse(Console.ReadLine());
Console.WriteLine("Please input your desired minutes: ");
int Minutes = int.Parse(Console.ReadLine());
Console.WriteLine("The time that you have chosen: {0}:{1}", Hours, Minutes);


// minute arrow moves by 6 degrees each minute
int LesserAngle = 6;
int MinAngle = LesserAngle * Minutes;

double HrsAngle = Hours * 30 + Minutes * 0.5;

double Angle = HrsAngle - MinAngle;
switch(Angle){
    case > 180.0:
        Console.WriteLine("The lesser angle between the arrows is: {0}", 360 - Angle);
        break;
    case <= 180.0:
        Console.WriteLine("The lesser angle between the arrows is: {0}", Angle);
        break;
    default:
        Console.WriteLine("The angles between both sides of the arrows are equal");
        break;
}