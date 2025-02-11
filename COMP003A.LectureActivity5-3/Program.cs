// Author: Riley Benson
// Course: COMP003A
// Faculty: Jonathan Cruz
// Purpose: To create a C# console application demonstrating abstraction using abstract classes and interfaces.

namespace COMP003A.LectureActivity5_3
{
	/// <summary>
	/// Represents a generic shape with an abstract method.
	/// </summary>
	abstract class Shape
	{
		// Auto-implemented property
		public string Name { get; set; }

		/// <summary>
		/// Abstract method to calculate area.
		/// </summary>
		public abstract double CalculateArea();

		/// <summary>
		/// Displays the shape’s name.
		/// </summary>
		public void DisplayInfo()
		{
			Console.WriteLine($"Shape: {Name}");
		}
	}
	/// <summary>
	/// Represents a circle derived from Shape.
	/// </summary>
	class Circle : Shape
	{
		// Auto-implemented property
		public double Radius { get; set; }

		/// <summary>
		/// Constructor for Circle.
		/// </summary>
		/// <param name="radius"></param>
		public Circle(double radius)
		{
			Name = "Circle";
			Radius = radius;
		}

		/// <summary>
		/// Calculates the area of the circle.
		/// </summary>
		public override double CalculateArea()
		{
			// returns the area of the circle
			return Math.PI * Radius * Radius;
		}
	}
	/// <summary>
	/// Represents a rectangle derived from Shape.
	/// </summary>
	class Rectangle : Shape
	{
		// Auto-implemented properties
		public double Width { get; set; }
		public double Height { get; set; }

		/// <summary>
		/// Constructor for Rectangle.
		/// </summary>
		/// <param name="width"></param>
		/// <param name="height"></param>
		public Rectangle(double width, double height)
		{
			Name = "Rectangle";
			Width = width;
			Height = height;
		}

		/// <summary>
		/// Calculates the area of the rectangle.
		/// </summary>
		public override double CalculateArea()
		{
			// returns the area of the rectangle
			return Width * Height;
		}
	}
	internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}