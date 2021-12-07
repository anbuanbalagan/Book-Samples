using System;

namespace Polymorphism
{
	public class PersonalityObject
	{
		public virtual string Speak()
		{
			return "Good Morning";
		}
	}

	public class PessimisticObject : PersonalityObject
	{
		public override string Speak()
		{
			return "This is PessimisticObject class";
		}
	}

	public class OptimisticObject : PersonalityObject
	{
		public override string Speak()
		{
			return "This is OptimisticObject class";
		}
	}

	public class IntrovertedObject : PersonalityObject
	{
		public override string Speak()
		{
			return "This is IntrovertedObject class";
		}
	}

	public class ExtrovertedObject : PersonalityObject
	{
		public override string Speak()
		{
			return "This is ExtrovertedObject class";
		}
	}

	class Program
	{
		static void Main(string[] args)
		{			
			PersonalityObject  personality = new PersonalityObject();			
			PessimisticObject pessimistic = new PessimisticObject();
			OptimisticObject optimistic = new OptimisticObject();
			IntrovertedObject introverted = new IntrovertedObject();
			ExtrovertedObject extroverted = new ExtrovertedObject();

			PersonalityObject[] personalities = new PersonalityObject[5];
			personalities[0] = personality;
			personalities[1] = pessimistic;
			personalities[2] = optimistic;
			personalities[3] = introverted;
			personalities[4] = extroverted;

			Console.WriteLine(personalities[0].Speak());
			Console.WriteLine(personalities[1].Speak());
			Console.WriteLine(personalities[2].Speak());
			Console.WriteLine(personalities[3].Speak());
			Console.WriteLine(personalities[4].Speak());
		}
	}
}
