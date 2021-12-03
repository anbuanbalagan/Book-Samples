using System;

namespace SimpleInheritance
{
	public class MoodyObject
	{
		protected  virtual string getMood()
		{
			return "Moody";
		}

		public void queryMood()
		{
			Console.WriteLine("I feel " + getMood() + " today!!");
		}
	}

	public class HappyObject : MoodyObject
	{
		protected override string getMood()
		{
			return "Happy";
		}

		public void laugh()
		{
			Console.WriteLine("hehehe....hahaha.....HAHAHAHA!!!!!!!");
		}
	}

	public class SadObject : MoodyObject
	{
		protected override string getMood()
		{
			return "Sad";
		}

		public void cry()
		{
			Console.WriteLine(" 'wah' 'boo hoo' 'weep' 'sob' ");
		}
	}

	public class MoodyDriver
	{
		public static void Main(string[] args)
		{
			MoodyObject moodyObject = new MoodyObject();
			SadObject sadObject = new SadObject();
			HappyObject happyObject = new HappyObject();

			Console.WriteLine("How does the moody object feel today?");
			moodyObject.queryMood();
			Console.WriteLine(" ");

			Console.WriteLine("How does the sad object feel today ?");
			sadObject.queryMood();
			sadObject.cry();
			Console.WriteLine(" ");

			Console.WriteLine("How does the sad object feel today ?");
			happyObject.queryMood();
			happyObject.laugh();
			Console.WriteLine(" ");
		}
	}	
}
