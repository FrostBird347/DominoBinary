﻿using System;
using System.IO;
using System.Linq;
using System.Text;

namespace DominoBinary
{
	public class Encode
	{
		public static void Start(string Input)
		{
			if (MainClass.SetArgs.InputType.ToUpper().StartsWith("F", StringComparison.Ordinal))
			{
				Console.WriteLine(GetEncodedData(File(Input)));
			}
			else if (MainClass.SetArgs.InputType.ToUpper().StartsWith("I", StringComparison.Ordinal))
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
			int bytecount = 0;
			foreach (byte b in binaryarray)
			{
				if (MainClass.SetArgs.Progress && !MainClass.SetArgs.Silent)
				{
					bytecount += 1;
					Console.Write("\r");
					Console.Write((new String('0', (binaryarray.Length.ToString().Length - bytecount.ToString().Length))) + bytecount + "/" + binaryarray.Length);
				}
				hexstring.AppendFormat("{0:x2}", b);
			}
			string binarystring = String.Join(String.Empty, hexstring.ToString().Select(c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')));
			string Output = "";
			bool Encoded = false;
			int addnum = 2;
			for (int i = 0; i < binarystring.Length; i += addnum)
			{
				if (MainClass.SetArgs.Progress && !MainClass.SetArgs.Silent)
				{
					Console.Write("\r");
					Console.Write((new String('0', (binarystring.Length.ToString().Length - i.ToString().Length))) + i + "/" + binarystring.Length);
				}
				Encoded = false;
				try
				{
					if (!Encoded)
					{
						switch (binarystring[i].ToString() + binarystring[i + 1].ToString() + binarystring[i + 2].ToString() + binarystring[i + 3].ToString() + binarystring[i + 4].ToString() + binarystring[i + 5].ToString() + binarystring[i + 6].ToString() + binarystring[i + 7].ToString() + binarystring[i + 8].ToString() + binarystring[i + 9].ToString() + binarystring[i + 10].ToString() + binarystring[i + 11].ToString())
						{
							case "000000000000":
								Output += RandEncode("🁡");
								Encoded = true;
								addnum = 12;
								break;
							case "111111111111":
								Output += RandEncode("🂓");
								Encoded = true;
								addnum = 12;
								break;
							default:
								break;
						}
					}
				}
				catch { }
				try
				{
					if (!Encoded)
					{
						switch (binarystring[i].ToString() + binarystring[i + 1].ToString() + binarystring[i + 2].ToString() + binarystring[i + 3].ToString() + binarystring[i + 4].ToString() + binarystring[i + 5].ToString() + binarystring[i + 6].ToString() + binarystring[i + 7].ToString() + binarystring[i + 8].ToString() + binarystring[i + 9].ToString() + binarystring[i + 10].ToString())
						{
							case "00000000000":
								Output += RandEncode("🁠");
								Encoded = true;
								addnum = 11;
								break;
							case "11111111111":
								Output += RandEncode("🂌");
								Encoded = true;
								addnum = 11;
								break;
							default:
								break;
						}
					}
				}
				catch { }
				try
				{
					if (!Encoded)
					{
						switch (binarystring[i].ToString() + binarystring[i + 1].ToString() + binarystring[i + 2].ToString() + binarystring[i + 3].ToString() + binarystring[i + 4].ToString() + binarystring[i + 5].ToString() + binarystring[i + 6].ToString() + binarystring[i + 7].ToString() + binarystring[i + 8].ToString() + binarystring[i + 9].ToString())
						{
							case "0000000000":
								Output += RandEncode("🁟");
								Encoded = true;
								addnum = 10;
								break;
							case "1111111111":
								Output += RandEncode("🂅");
								Encoded = true;
								addnum = 10;
								break;
							default:
								break;
						}
					}
				}
				catch { }
				try
				{
					if (!Encoded)
					{
						switch (binarystring[i].ToString() + binarystring[i + 1].ToString() + binarystring[i + 2].ToString() + binarystring[i + 3].ToString() + binarystring[i + 4].ToString() + binarystring[i + 5].ToString() + binarystring[i + 6].ToString() + binarystring[i + 7].ToString() + binarystring[i + 8].ToString())
						{
							case "000000000":
								Output += RandEncode("🁞");
								Encoded = true;
								addnum = 9;
								break;
							case "111111111":
								Output += RandEncode("🁾");
								Encoded = true;
								addnum = 9;
								break;
							default:
								break;
						}
					}
				}
				catch { }
				try
				{
					if (!Encoded)
					{
						switch (binarystring[i].ToString() + binarystring[i + 1].ToString() + binarystring[i + 2].ToString() + binarystring[i + 3].ToString() + binarystring[i + 4].ToString() + binarystring[i + 5].ToString() + binarystring[i + 6].ToString() + binarystring[i + 7].ToString())
						{
							case "00000000":
								Output += RandEncode("🁝");
								Encoded = true;
								addnum = 8;
								break;
							case "11111111":
								Output += RandEncode("🁷");
								Encoded = true;
								addnum = 8;
								break;
							default:
								break;
						}
					}
				}
				catch { }
				try
				{
					if (!Encoded)
					{
						switch (binarystring[i].ToString() + binarystring[i + 1].ToString() + binarystring[i + 2].ToString() + binarystring[i + 3].ToString() + binarystring[i + 4].ToString() + binarystring[i + 5].ToString() + binarystring[i + 6].ToString())
						{
							case "0000000":
								Output += RandEncode("🁜");
								Encoded = true;
								addnum = 7;
								break;
							case "1111111":
								Output += RandEncode("🁰");
								Encoded = true;
								addnum = 7;
								break;
							default:
								break;
						}
					}
				}
				catch { }
				try
				{
					if (!Encoded)
					{
						switch (binarystring[i].ToString() + binarystring[i + 1].ToString() + binarystring[i + 2].ToString() + binarystring[i + 3].ToString() + binarystring[i + 4].ToString() + binarystring[i + 5].ToString())
						{
							case "000000":
								Output += RandEncode("🁛");
								Encoded = true;
								addnum = 6;
								break;
							case "111111":
								Output += RandEncode("🁩");
								Encoded = true;
								addnum = 6;
								break;
							default:
								break;
						}
					}
				}
				catch { }
				try
				{
					if (!Encoded)
					{
						switch (binarystring[i].ToString() + binarystring[i + 1].ToString() + binarystring[i + 2].ToString() + binarystring[i + 3].ToString() + binarystring[i + 4].ToString())
						{
							case "00000":
								Output += RandEncode("🁔");
								Encoded = true;
								addnum = 5;
								break;
							case "11111":
								Output += RandEncode("🁨");
								Encoded = true;
								addnum = 5;
								break;
							default:
								break;
						}
					}
				} catch { }
				try
				{
					if (!Encoded)
					{
						switch (binarystring[i].ToString() + binarystring[i + 1].ToString() + binarystring[i + 2].ToString() + binarystring[i + 3].ToString())
						{
							case "0000":
								Output += RandEncode("🁍");
								Encoded = true;
								addnum = 4;
								break;
							case "1111":
								Output += RandEncode("🁧");
								Encoded = true;
								addnum = 4;
								break;
							default:
								break;
						}
					}
				}
				catch { }
				try
				{
					if (!Encoded)
					{

						switch (binarystring[i].ToString() + binarystring[i + 1].ToString() + binarystring[i + 2].ToString())
						{
							case "000":
								Output += RandEncode("🁆");
								Encoded = true;
								addnum = 3;
								break;
							case "111":
								Output += RandEncode("🁦");
								Encoded = true;
								addnum = 3;
								break;
							default:
								break;
						}
					}
				}
				catch { }
				try
				{
					if (!Encoded)
					{
						switch (binarystring[i].ToString() + binarystring[i + 1].ToString())
						{
							case "00":
								Output += RandEncode("🀿");
								addnum = 2;
								break;
							case "11":
								Output += RandEncode("🁥");
								addnum = 2;
								break;
							default:
								throw new Exception();
						}
					}
				}
				catch (Exception)
				{
					switch (binarystring[i].ToString())
					{
						case "0":
							Output += RandEncode("🀸");
							addnum = 1;
							break;
						case "1":
							Output += RandEncode("🁤");
							addnum = 1;
							break;
						default:
							throw new Exception("Invalid character in binary: " + binarystring[i].ToString());
					}
				}
				if (MainClass.SetArgs.Progress && !MainClass.SetArgs.Silent)
				{
					Console.Write("\r");
					Console.Write((new String('0', (binarystring.Length.ToString().Length - (i + addnum).ToString().Length))) + (i + addnum) + "/" + binarystring.Length);
				}

			}
			string FinalOutput = Output;
			if (MainClass.SetArgs.ASCII)
			{
				if (MainClass.SetArgs.BOTH)
				{
					if (MainClass.SetArgs.Silent)
					{
						Console.Write(Output + "\n");
					}
					else
					{
						Console.Write("\n--------------\n" + Output); 
					}
				}
				FinalOutput = Output.Replace("🂓", "{6,6}").Replace("🂒", "{6,5}").Replace("🂑", "{6|4}").Replace("🂐", "{6|3}").Replace("🂏", "{6|2}").Replace("🂎", "{6|1}").Replace("🂍", "{6|0}").Replace("🂌", "{5|6}").Replace("🂋", "{5|5}").Replace("🂊", "{5|4}").Replace("🂉", "{5|3}").Replace("🂈", "{5|2}").Replace("🂇", "{5|1}").Replace("🂆", "{5|0}").Replace("🂅", "{4|6}").Replace("🂄", "{4|5}").Replace("🂃", "{4|4}").Replace("🂂", "{4|3}").Replace("🂁", "{4|2}").Replace("🂀", "{4|1}").Replace("🁿", "{4|0}").Replace("🁾", "{3|6}").Replace("🁽", "{3|5}").Replace("🁼", "{3|4}").Replace("🁻", "{3|3}").Replace("🁺", "{3|2}").Replace("🁹", "{3|1}").Replace("🁸", "{3|0}").Replace("🁷", "{2|6}").Replace("🁶", "{2|5}").Replace("🁵", "{2|4}").Replace("🁴", "{2|3}").Replace("🁳", "{2|2}").Replace("🁲", "{2|1}").Replace("🁱", "{2|0}").Replace("🁰", "{1|6}").Replace("🁯", "{1|5}").Replace("🁮", "{1|4}").Replace("🁭", "{1|3}").Replace("🁬", "{1|2}").Replace("🁫", "{1|1}").Replace("🁪", "{1|0}").Replace("🁩", "{0|6}").Replace("🁨", "{0|5}").Replace("🁧", "{0|4}").Replace("🁦", "{0|3}").Replace("🁥", "{0|2}").Replace("🁤", "{0|1}").Replace("🁣", "{0|0}").Replace("🁡", "(6|6)").Replace("🁠", "(6|5)").Replace("🁟", "(6|4)").Replace("🁞", "(6|3)").Replace("🁝", "(6|2)").Replace("🁜", "(6|1)").Replace("🁛", "(6|0)").Replace("🁚", "(5|6)").Replace("🁙", "(5|5)").Replace("🁘", "(5|4)").Replace("🁗", "(5|3)").Replace("🁖", "(5|2)").Replace("🁕", "(5|1)").Replace("🁔", "(5|0)").Replace("🁓", "(4|6)").Replace("🁒", "(4|5)").Replace("🁑", "(4|4)").Replace("🁐", "(4|3)").Replace("🁏", "(4|2)").Replace("🁎", "(4|1)").Replace("🁍", "(4|0)").Replace("🁌", "(3|6)").Replace("🁋", "(3|5)").Replace("🁊", "(3|4)").Replace("🁉", "(3|3)").Replace("🁈", "(3|2)").Replace("🁇", "(3|1)").Replace("🁆", "(3|0)").Replace("🁅", "(2|6)").Replace("🁄", "(2|5)").Replace("🁃", "(2|4)").Replace("🁂", "(2|3)").Replace("🁁", "(2|2)").Replace("🁀", "(2|1)").Replace("🀿", "(2|0)").Replace("🀾", "(1|6)").Replace("🀽", "(1|5)").Replace("🀼", "(1|4)").Replace("🀻", "(1|3)").Replace("🀺", "(1|2)").Replace("🀹", "(1|1)").Replace("🀸", "(1|0)").Replace("🀷", "(0|6)").Replace("🀶", "(0|5)").Replace("🀵", "(0|4)").Replace("🀴", "(0|3)").Replace("🀳", "(0|2)").Replace("🀲", "(0|1)").Replace("🀱", "(0|0)");
			}
			if (MainClass.SetArgs.Silent)
			{
				return FinalOutput;
			}
			else
			{
				return "\n--------------\n" + FinalOutput + "\n--------------\n";
			}
		}

		public static string RandEncode(string symbol)
		{
			if ("🂒🂌".Contains(symbol))
			{
				return new string[] { "🂒", "🂌" }[new Random().Next(2)];
			}
			else if ("🂑🂋🂅".Contains(symbol))
			{
				return new string[] { "🂑", "🂋", "🂅" }[new Random().Next(3)];
			}
			else if ("🂐🂊🂄🁾".Contains(symbol))
			{
				return new string[] { "🂐", "🂊", "🂄", "🁾" }[new Random().Next(4)];
			}
			else if ("🂏🂉🂃🁽🁷".Contains(symbol))
			{
				return new string[] { "🂏", "🂉", "🂃", "🁽", "🁷" }[new Random().Next(5)];
			}
			else if ("🂎🂈🂂🁼🁶🁰".Contains(symbol))
			{
				return new string[] { "🂎", "🂈", "🂂", "🁼", "🁶", "🁰" }[new Random().Next(6)];
			}
			else if ("🂍🂇🂁🁻🁵🁯🁩".Contains(symbol))
			{
				return new string[] { "🂍", "🂇", "🂁", "🁻", "🁵", "🁯", "🁩" }[new Random().Next(7)];
			}
			else if ("🂆🂀🁺🁴🁮🁨".Contains(symbol))
			{
				return new string[] { "🂆", "🂀", "🁺", "🁴", "🁮", "🁨" }[new Random().Next(6)];
			}
			else if ("🁿🁹🁳🁭🁧".Contains(symbol))
			{
				return new string[] { "🁿", "🁹", "🁳", "🁭", "🁧" }[new Random().Next(5)];
			}
			else if ("🁸🁲🁬🁦".Contains(symbol))
			{
				return new string[] { "🁸", "🁲", "🁬", "🁦" }[new Random().Next(4)];
			}
			else if ("🁱🁫🁥".Contains(symbol))
			{
				return new string[] { "🁱", "🁫", "🁥" }[new Random().Next(3)];
			}
			else if ("🁪🁤".Contains(symbol))
			{
				return new string[] { "🁪", "🁤" }[new Random().Next(2)];
			}
			else if ("🁠🁚".Contains(symbol))
			{
				return new string[] { "🁠", "🁚" }[new Random().Next(2)];
			}
			else if ("🁟🁙🁓".Contains(symbol))
			{
				return new string[] { "🁟", "🁙", "🁓" }[new Random().Next(3)];
			}
			else if ("🁞🁘🁒🁌".Contains(symbol))
			{
				return new string[] { "🁞", "🁘", "🁒", "🁌" }[new Random().Next(4)];
			}
			else if ("🁝🁗🁑🁋🁅".Contains(symbol))
			{
				return new string[] { "🁝", "🁗", "🁑", "🁋", "🁅" }[new Random().Next(5)];
			}
			else if ("🁜🁖🁐🁊🁄🀾".Contains(symbol))
			{
				return new string[] { "🁜", "🁖", "🁐", "🁊", "🁄", "🀾" }[new Random().Next(6)];
			}
			else if ("🁛🁕🁏🁉🁃🀽🀷".Contains(symbol))
			{
				return new string[] { "🁛", "🁕", "🁏", "🁉", "🁃", "🀽", "🀷" }[new Random().Next(7)];
			}
			else if ("🁔🁎🁈🁂🀼🀶".Contains(symbol))
			{
				return new string[] { "🁔", "🁎", "🁈", "🁂", "🀼", "🀶" }[new Random().Next(6)];
			}
			else if ("🁍🁇🁁🀻🀵".Contains(symbol))
			{
				return new string[] { "🁍", "🁇", "🁁", "🀻", "🀵" }[new Random().Next(5)];
			}
			else if ("🁆🁀🀺🀴".Contains(symbol))
			{
				return new string[] { "🁆", "🁀", "🀺", "🀴" }[new Random().Next(4)];
			}
			else if ("🀿🀹🀳".Contains(symbol))
			{
				return new string[] { "🀿", "🀹", "🀳" }[new Random().Next(3)];
			}
			else if ("🀸🀲".Contains(symbol))
			{
				return new string[] { "🀸", "🀲" }[new Random().Next(2)];
			}
			else
			{
				return symbol;
			}
		}
	}
}