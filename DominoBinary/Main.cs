using System;
using CommandLine;

namespace DominoBinary
{
	class MainClass
	{
		public static Options SetArgs;
		public static bool Complete = false;
		public static void Main(string[] args)
		{
			Parser.Default.ParseArguments<Options>(args).WithParsed(Start);
		}

		public static void Start(Options args)
		{
			SetArgs = args;
			switch (args.Legacy)
			{
				case false:
					switch (args.MainMode.ToLower())
					{
						case "e":
							Encode.Start(args.Input);
							break;
						case "d":
							Decode.Start(args.Input);
							break;
						case "decode":
							Decode.Start(args.Input);
							break;
						case "encode":
							Encode.Start(args.Input);
							break;
					}
					break;
				case true:
					switch (args.MainMode.ToLower())
					{
						case "e":
							OldEncode.Start(args.Input);
							break;
						case "d":
							OldDecode.Start(args.Input);
							break;
						case "decode":
							OldDecode.Start(args.Input);
							break;
						case "encode":
							OldEncode.Start(args.Input);
							break;
					}
					break;
			}
			if (!Complete)
			{
				InvalidArgs("Invalid mode. Valid values are: 'e', 'd', 'decode', 'encode'.");
			}
		}
		public static void InvalidArgs(string InvalidReason)
		{
			Console.WriteLine("Error: " + InvalidReason);
			Parser.Default.ParseArguments<Options>("--help".Split(' '));
			System.Environment.Exit(1);
		}
	}
}