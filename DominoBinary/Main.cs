using System;

namespace DominoBinary
{
	class MainClass
	{
		public static string V = "1.1.0";
		public static void Main(string[] args)
		{
			try
			{
				if (args[0] == "v")
				{
					OutputVersion();
				}
				String test = (args[2]);
			}
			catch (Exception)
			{
				InvalidArgs();
			}
			switch (args[2])
			{
				case "2":
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
					break;
				case "1":
					switch (args[0].ToLower())
					{
						case "e":
							OldEncode.Start(args[1]);
							break;
						case "d":
							OldDecode.Start(args[1]);
							break;
						case "decode":
							OldDecode.Start(args[1]);
							break;
						case "encode":
							OldEncode.Start(args[1]);
							break;
					}
					break;
				default:
					InvalidArgs();
					break;

			}

		}
		public static void InvalidArgs()
		{
			Console.WriteLine("Error: invalid arguments!");
			Console.WriteLine("Correct usage:");
			Console.WriteLine("	DominoBinary.exe [e/d/v/encode/decode] [F:filepath/I:input] [1/2]");
			Console.WriteLine("Examples:");
			Console.WriteLine("	DominoBinary.exe e F:file.txt 1");
			Console.WriteLine("	DominoBinary.exe encode I:hello 2");
			Console.WriteLine("	DominoBinary.exe d I:message\\ with\\ spaces 2");
			Console.WriteLine("	DominoBinary.exe d 'I:message with spaces' 2");
			Console.WriteLine("	DominoBinary.exe decode F:file.txt 1");
			Console.WriteLine("	DominoBinary.exe v");
			System.Environment.Exit(1);
		}

		public static void OutputVersion()
		{
			Console.WriteLine("DominoBinary - Version " + V);
			System.Environment.Exit(1);
		}

	}
}
