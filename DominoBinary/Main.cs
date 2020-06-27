using System;

namespace DominoBinary
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			try
			{
				String test = (args[1]);
			}
			catch(Exception)
			{
				InvalidArgs();
			}
			switch (args[0].ToLower())
			{
				case "e":
					Encode.Start(args[1]);
					break;
				case "d":
					Decode.Start(args[1]);
					break;
				case "decode":
					Decode.Start(args[1]);
					break;
				case "encode":
					Encode.Start(args[1]);
					break;
			}
		}

		public static void InvalidArgs()
		{
			Console.WriteLine("Error: invalid arguments!");
			Console.WriteLine("Correct usage:");
			Console.WriteLine("	DominoBinary.exe [e/d/encode/decode] [F:filepath/I:input]");
			Console.WriteLine("Examples:");
			Console.WriteLine("	DominoBinary.exe e F:file.txt");
			Console.WriteLine("	DominoBinary.exe encode I:hello");
			Console.WriteLine("	DominoBinary.exe d I:message\\ with\\ spaces");
			Console.WriteLine("	DominoBinary.exe d 'I:message with spaces'");
			Console.WriteLine("	DominoBinary.exe decode F:file.txt");
			System.Environment.Exit(1);
		}

	}
}
