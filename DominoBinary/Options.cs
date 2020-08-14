using System;
using System.Collections.Generic;
using CommandLine;
namespace DominoBinary
{
	public class Options
	{
		[Option('m', "mode", Required = true, HelpText = "Encode or decode text. Valid values are 'e', 'd', 'encode' and 'decode'.")]
		public string MainMode { get; set; }

		[Option('t', "type", Required = true, HelpText = "Input type. Valid values are F and I. (F = file and I = input)")]
		public string InputType { get; set; }

		[Option('i', "input", Required = true, HelpText = "Input. Enter the text (or file path) you want encoded or decoded here.")]
		public string Input { get; set; }

		[Option('b', "batch", Default = false, HelpText = "Remove the seperators before and after an output. Usefull for decoding and encoding binary files")]
		public bool Silent { get; set; }

		[Option("legacy", Default = false, HelpText = "Use legacy encoder/decoder.")]
		public bool Legacy { get; set; }

		[Option("version", Default = false, HelpText = "Print version.")]
		public bool PrintVersion { get; set; }
	}
}