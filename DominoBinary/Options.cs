﻿using System;
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

		[Option('b', "batch", Default = false, HelpText = "Remove the separators before and after an output. Useful for decoding and encoding binary files.")]
		public bool Silent { get; set; }

		[Option("progress", Default = false, HelpText = "Shows a progress bar, ignored if batch mode is active.")]
		public bool Progress { get; set; }

		[Option("legacy", Default = false, HelpText = "Use legacy encoder/decoder, does not support ASCII only mode.")]
		public bool Legacy { get; set; }

		[Option("ascii", Default = false, HelpText = "Use ASCII only encoder/decoder, legacy mode is not supported.")]
		public bool ASCII { get; set; }

		[Option("both", Default = false, HelpText = "Use ASCII only encoder/decoder and unicode encoder/decoder together with the same seeds. Legacy mode is not supported and decode isn't supported either.")]
		public bool BOTH { get; set; }
	}
}