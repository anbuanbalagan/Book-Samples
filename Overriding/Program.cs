using System;

namespace Overriding
{
	public class MoodyObject
	{
		protected virtual string getMood()
		{
			return "Moody";
		}

		public void queryMood()
		{
			Console.WriteLine("I feel " + getMood() + " today!");
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
			Console.WriteLine("hehehe.....hahahaha...!");
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			MoodyObject moody = new MoodyObject();
			HappyObject happy = new HappyObject();
			moody.queryMood();
			happy.queryMood();
			happy.laugh();
		}
	}
}
