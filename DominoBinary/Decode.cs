using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DominoBinary
{
	public class Decode
	{
		public static void Start(string Input)
		{
			if (Input.ToUpper().StartsWith("F:"))
			{
				Console.WriteLine(GetDecodedData(File(Input.Substring(2))));
			}
			else if (Input.ToUpper().StartsWith("I:"))
			{
				Console.WriteLine(GetDecodedData(Input.Substring(2)));
			}
			else
			{
				MainClass.InvalidArgs();
			}
		}

		public static string File(string RawFilePath)
		{
			string fullpath = Path.GetFullPath(RawFilePath);
			return System.IO.File.ReadAllText(fullpath);
		}

		public static string GetDecodedData(string Input)
		{
			//Easier to read when on multiple lines
			string binarystring = Input.Replace("🁡", "000000000000").Replace("🂓", "111111111111");
			binarystring = binarystring.Replace("🁠", "00000000000").Replace("🂌", "11111111111");
			binarystring = binarystring.Replace("🁟", "0000000000").Replace("🂅", "1111111111");
			binarystring = binarystring.Replace("🁞", "000000000").Replace("🁾", "111111111");
			binarystring = binarystring.Replace("🁝", "00000000").Replace("🁷", "11111111");
			binarystring = binarystring.Replace("🁜", "0000000").Replace("🁰", "1111111");
			binarystring = binarystring.Replace("🁛", "000000").Replace("🁩", "111111");
			binarystring = binarystring.Replace("🁔", "00000").Replace("🁨", "11111");
			binarystring = binarystring.Replace("🁍", "0000").Replace("🁧", "1111");
			binarystring = binarystring.Replace("🁆", "000").Replace("🁦", "111");
			binarystring = binarystring.Replace("🀿", "00").Replace("🁥", "11");
			binarystring = binarystring.Replace("🀸", "0").Replace("🁤", "1");
			List<Byte> byteList = new List<Byte>();
			try
			{
				for (int i = 0; i < binarystring.Length; i += 8)
				{
					byteList.Add(Convert.ToByte(binarystring.Substring(i, 8), 2));
				}
			}
			catch
			{
				Console.WriteLine("Error decoding, attempting to use incomplete data...");
			}
			var Output = Encoding.Unicode.GetString(byteList.ToArray());
			return "\n--------------\n" + Output + "\n--------------\n";
		}
	}
}