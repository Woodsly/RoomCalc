/* Name: Connor Wood
 * Date : 6/21/2022
 * Project: Room Calc Lab 1
 */

Console.WriteLine("Welcome to Connor's Room Detail Generator!");
Console.WriteLine("Please enter the length of the room: ");
double length = double.Parse(Console.ReadLine());
Console.WriteLine("Please enter the width of the room: ");
double width = double.Parse(Console.ReadLine());
double area = width * length;
double perimeter = length + length + width + width;
Console.WriteLine("Area: " + area + " feet");
Console.WriteLine("Perimeter: " + perimeter + " feet");

Console.WriteLine("What is the height of your room?");
double height = double.Parse(Console.ReadLine());
double volume = length * width * height;
Console.WriteLine("Your room has a volume of " + volume + " cubic feet!");

double surface_area = 2 * (width * length + height * length + height * width);
Console.WriteLine("The surface area is: " + surface_area + " square feet");

if(area > 0 && area <= 250)
{
    Console.WriteLine("This is a small room");
}else if (area > 250 && area <= 650)
{
    Console.WriteLine("This is a medium size room");
}else
{
    Console.WriteLine("Wow this room is massive!");
}