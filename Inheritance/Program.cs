using System;

namespace Inheritance
{
	public class Employee
	{
		private string first_name;
		private string last_name;
		private double wage;

		public Employee(string first_name, string last_name, double wage)
		{
			this.first_name = first_name;
			this.last_name = last_name;
			this.wage = wage;
		}

		public double getWage()
		{
			return wage;
		}

		public string getFirstName()
		{
			return first_name;
		}

		public string getLastName()
		{
			return last_name;
		}
	}

	public class CommissionedEmployee : Employee
	{
		private double commission; 
		private int units;

		public CommissionedEmployee(string first_name, string last_name, double wage, double commission):base(first_name, last_name, wage)
		{
			this.commission = commission;
		}

		public double calculatePay()
		{
			return getWage() + (commission * units);
		}

		public void addSales(int units)
		{
			this.units = this.units + units;
		}

		public void resetSales()
		{
			units = 0;
		}
	}

	class Program
	{ 
		public static void Main()
		{
			CommissionedEmployee c = new CommissionedEmployee("Mr.Jack","Ryan", 15.50, 1.00);

			c.addSales(10);
			Console.WriteLine("First Name "+c.getFirstName());
			Console.WriteLine("Last Name " + c.getLastName());
			Console.WriteLine("Base Pay : $" + c.getWage());
			Console.WriteLine("Total Pay : $" + c.calculatePay());

			TwoDimensionalPoint two = new TwoDimensionalPoint(3, 2);
			ThreeDimensionalPoint three = new ThreeDimensionalPoint(5, 2, 3);

			Console.WriteLine("\n");
			Console.WriteLine(two.toString());
			Console.WriteLine(three.toString());
		}
	}
}



