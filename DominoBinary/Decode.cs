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
			if (MainClass.SetArgs.InputType.ToUpper().StartsWith("F", StringComparison.Ordinal))
			{
				Console.WriteLine(GetDecodedData(File(Input)));
			}
			else if (MainClass.SetArgs.InputType.ToUpper().StartsWith("I", StringComparison.Ordinal))
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
			//This took forever
			Dictionary<string, string> DecodeMap = new Dictionary<string, string>();
			DecodeMap.Add("🂓", "111111111111");
			DecodeMap.Add("🂒", "11111111111");
			DecodeMap.Add("🂑", "1111111111");
			DecodeMap.Add("🂐", "111111111");
			DecodeMap.Add("🂏", "11111111");
			DecodeMap.Add("🂎", "1111111");
			DecodeMap.Add("🂍", "111111");
			DecodeMap.Add("🂌", "11111111111");
			DecodeMap.Add("🂋", "1111111111");
			DecodeMap.Add("🂊", "111111111");
			DecodeMap.Add("🂉", "11111111");
			DecodeMap.Add("🂈", "1111111");
			DecodeMap.Add("🂇", "111111");
			DecodeMap.Add("🂆", "11111");
			DecodeMap.Add("🂅", "1111111111");
			DecodeMap.Add("🂄", "111111111");
			DecodeMap.Add("🂃", "11111111");
			DecodeMap.Add("🂂", "1111111");
			DecodeMap.Add("🂁", "111111");
			DecodeMap.Add("🂀", "11111");
			DecodeMap.Add("🁿", "1111");
			DecodeMap.Add("🁾", "111111111");
			DecodeMap.Add("🁽", "11111111");
			DecodeMap.Add("🁼", "1111111");
			DecodeMap.Add("🁻", "111111");
			DecodeMap.Add("🁺", "11111");
			DecodeMap.Add("🁹", "1111");
			DecodeMap.Add("🁸", "111");
			DecodeMap.Add("🁷", "11111111");
			DecodeMap.Add("🁶", "1111111");
			DecodeMap.Add("🁵", "111111");
			DecodeMap.Add("🁴", "11111");
			DecodeMap.Add("🁳", "1111");
			DecodeMap.Add("🁲", "111");
			DecodeMap.Add("🁱", "11");
			DecodeMap.Add("🁰", "1111111");
			DecodeMap.Add("🁯", "111111");
			DecodeMap.Add("🁮", "11111");
			DecodeMap.Add("🁭", "1111");
			DecodeMap.Add("🁬", "111");
			DecodeMap.Add("🁫", "11");
			DecodeMap.Add("🁪", "1");
			DecodeMap.Add("🁩", "111111");
			DecodeMap.Add("🁨", "11111");
			DecodeMap.Add("🁧", "1111");
			DecodeMap.Add("🁦", "111");
			DecodeMap.Add("🁥", "11");
			DecodeMap.Add("🁤", "1");
			DecodeMap.Add("🁣", String.Empty);
			DecodeMap.Add("🁡", "000000000000");
			DecodeMap.Add("🁠", "00000000000");
			DecodeMap.Add("🁟", "0000000000");
			DecodeMap.Add("🁞", "000000000");
			DecodeMap.Add("🁝", "00000000");
			DecodeMap.Add("🁜", "0000000");
			DecodeMap.Add("🁛", "000000");
			DecodeMap.Add("🁚", "00000000000");
			DecodeMap.Add("🁙", "0000000000");
			DecodeMap.Add("🁘", "000000000");
			DecodeMap.Add("🁗", "00000000");
			DecodeMap.Add("🁖", "0000000");
			DecodeMap.Add("🁕", "000000");
			DecodeMap.Add("🁔", "00000");
			DecodeMap.Add("🁓", "0000000000");
			DecodeMap.Add("🁒", "000000000");
			DecodeMap.Add("🁑", "00000000");
			DecodeMap.Add("🁐", "0000000");
			DecodeMap.Add("🁏", "000000");
			DecodeMap.Add("🁎", "00000");
			DecodeMap.Add("🁍", "0000");
			DecodeMap.Add("🁌", "000000000");
			DecodeMap.Add("🁋", "00000000");
			DecodeMap.Add("🁊", "0000000");
			DecodeMap.Add("🁉", "000000");
			DecodeMap.Add("🁈", "00000");
			DecodeMap.Add("🁇", "0000");
			DecodeMap.Add("🁆", "000");
			DecodeMap.Add("🁅", "00000000");
			DecodeMap.Add("🁄", "0000000");
			DecodeMap.Add("🁃", "000000");
			DecodeMap.Add("🁂", "00000");
			DecodeMap.Add("🁁", "0000");
			DecodeMap.Add("🁀", "000");
			DecodeMap.Add("🀿", "00");
			DecodeMap.Add("🀾", "0000000");
			DecodeMap.Add("🀽", "000000");
			DecodeMap.Add("🀼", "00000");
			DecodeMap.Add("🀻", "0000");
			DecodeMap.Add("🀺", "000");
			DecodeMap.Add("🀹", "00");
			DecodeMap.Add("🀸", "0");
			DecodeMap.Add("🀷", "000000");
			DecodeMap.Add("🀶", "00000");
			DecodeMap.Add("🀵", "0000");
			DecodeMap.Add("🀴", "000");
			DecodeMap.Add("🀳", "00");
			DecodeMap.Add("🀲", "0");
			DecodeMap.Add("🀱", String.Empty);
			string tmpDecode = Input;
			int KeyCount = 0;
			foreach (KeyValuePair<string, string> replacement in DecodeMap)
			{
				if (MainClass.SetArgs.Progress && !MainClass.SetArgs.Silent)
				{
					KeyCount++;
					Console.Write("\r");
					Console.Write(KeyCount + "/" + DecodeMap.Count);
				}
				tmpDecode = tmpDecode.Replace(replacement.Key, replacement.Value);
			}
			string binarystring = tmpDecode;
			List<Byte> byteList = new List<Byte>();
			try
			{
				for (int i = 0; i < binarystring.Length; i += 8)
				{
					if (MainClass.SetArgs.Progress && !MainClass.SetArgs.Silent)
					{
						Console.Write("\r");
						Console.Write((new String('0', (binarystring.Length.ToString().Length - i.ToString().Length))) + i + "/" + binarystring.Length);
					}
					byteList.Add(Convert.ToByte(binarystring.Substring(i, 8), 2));
				}
			}
			catch
			{
				Console.WriteLine("\nError decoding, attempting to use incomplete data...");
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