using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
	public class TwoDimensionalPoint
	{
		private double x_coord;
		private double y_coord;

		public TwoDimensionalPoint(double x, double y)
		{
			setXCoordinate(x);
			setYCoordinate(y);
		}

		public double getXCoordinate()
		{
			return x_coord;
		}

		public void setXCoordinate(double x)
		{
			x_coord = x;
		}

		public double getYCoordinate()
		{
			return y_coord;
		}

		public void setYCoordinate(double y)
		{
			y_coord = y;
		}

		public string toString()
		{
			Console.WriteLine("\n");
			return "This is a 2 dimensional point.\n" +
				"My x coordinate is: " +getXCoordinate() + "\n" +
				"My y coordinate is: " +getYCoordinate();
		}
	}

	public class ThreeDimensionalPoint : TwoDimensionalPoint
	{
		private double z_coord;

		public ThreeDimensionalPoint(double x, double y, double z) : base(x,y)
		{			
			setZCoordinate(z);
		}

		public double getZCoordinate()
		{
			return z_coord;
		}

		public void setZCoordinate(double z)
		{
			z_coord = z;
		}

		public string toString()
		{
			Console.WriteLine("\n");
			return "This is a 3 dimensional point.\n" +
			"My x coordinate is: " +getXCoordinate() + "\n" +
			"My y coordinate is: " +getYCoordinate() + "\n" +
			"My z coordinate is: " +getZCoordinate();
		}
	}
}

