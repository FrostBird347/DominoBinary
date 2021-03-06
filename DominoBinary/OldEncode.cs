﻿using System;
using System.IO;
using System.Linq;
using System.Text;

namespace DominoBinary
{
	public class OldEncode
	{
		public static void Start(string Input)
		{
			if (MainClass.SetArgs.InputType.ToUpper().StartsWith("F"))
			{
				Console.WriteLine(GetEncodedData(File(Input)));
			}
			else if (MainClass.SetArgs.InputType.ToUpper().StartsWith("I"))
			{
				Console.WriteLine(GetEncodedData(Input));
			}
			else
			{
				MainClass.InvalidArgs("Invalid type. Valid values are: 'F', 'I', 'File', 'Input'.");
			}
			MainClass.Complete = true;
		}

		public static string File(string RawFilePath)
		{
			string fullpath = Path.GetFullPath(RawFilePath);
			return System.IO.File.ReadAllText(fullpath);
		}

		//TODO: Convert string to binary instead of string to hex to binary
		public static string GetEncodedData(string Input)
		{
			byte[] binaryarray = System.Text.Encoding.Unicode.GetBytes(Input);
			StringBuilder hexstring = new StringBuilder(Input.Length * 2);
			foreach (byte b in binaryarray)
				hexstring.AppendFormat("{0:x2}", b);
			string binarystring = String.Join(String.Empty, hexstring.ToString().Select(c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')));
			string Output = "";
			for (int i = 0; i < binarystring.Length; i += 2)
			{
				switch (binarystring[i].ToString() + binarystring[i + 1].ToString())
				{
					case "00":
						Output += "🀱";
						break;
					case "01":
						Output += "🀲";
						break;
					case "10":
						Output += "🀸";
						break;
					case "11":
						Output += "🀹";
						break;
					default:
						throw new Exception("Invalid character in binary: " + binarystring[i].ToString() + binarystring[i + 1].ToString());
				}
			}
			if (MainClass.SetArgs.Silent)
			{
				return Output;
			}
			else
			{
				return "\n--------------\n" + Output + "\n--------------\n";
			}
		}
	}
}