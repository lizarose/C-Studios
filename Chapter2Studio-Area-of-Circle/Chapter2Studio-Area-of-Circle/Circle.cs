namespace Helpers;

    public class Circle
    {
        
       //start with modifiers, then return type, method name, parameter list
        public static double Area(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        // double area = 3.14 * radius * radius;

        }

        public static double Circumference(double radius)
        {
            return 2 * Math.PI * radius;
        }
        
        public static double Diameter(double radius)
        {
            return 2 * radius;
        }

    }

