using Helpers;
//Bonus Mission: do-while loop for negative number or empty input
//Calculate the area of a circle.
// Console.WriteLine("Enter a radius: ");
// double radius = double.Parse(Console.ReadLine());
double radius;
do {
    Console.WriteLine("Enter a radius: ");
    string input = Console.ReadLine();
    if (input == "" || !double.TryParse(input, out radius))
    {
        Console.WriteLine("Exiting program...");
        Environment.Exit(0);
    }
    radius = double.Parse(input);
    if (radius < 0)
    {
        Console.WriteLine("Radius can't be negative, try again.");
    }
}  while (radius < 0);


//Area calculation:
double area = Circle.Area(radius);
Console.WriteLine("The area of a circle with a radius of " + radius + " is: " + area + ".");


//Circumference and diameter of the circle:
double circumference = Circle.Circumference(radius);
double diameter = Circle.Diameter(radius);



Console.WriteLine("The circumference of the circle with a radius of " + radius + " is: " + circumference + ".");
Console.WriteLine("The diameter of the circle with the radius of " + radius + " is: " + diameter + ".");


//Road Trip!
Console.WriteLine("How many miles per gallon of your car do you have? ");
double mpg = double.Parse(Console.ReadLine());

double gallons = circumference / mpg;

Console.WriteLine("The car will use " + gallons + " gallons of gas to go around the circle.");



    

