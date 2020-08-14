using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DominoBinary
{
	public class OldDecode
	{
		public static void Start(string Input)
		{
			if (MainClass.SetArgs.InputType.ToUpper().StartsWith("F"))
			{
				Console.WriteLine(GetDecodedData(File(Input)));
			}
			else if (MainClass.SetArgs.InputType.ToUpper().StartsWith("I"))
			{
				Console.WriteLine(GetDecodedData(Input));
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

		public static string GetDecodedData(string Input)
		{
			string binarystring = Input.Replace("🀱", "00").Replace("🀲", "01").Replace("🀸", "10").Replace("🀹", "11");
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