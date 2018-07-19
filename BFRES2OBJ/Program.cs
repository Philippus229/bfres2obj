using System;
using BfresLib;
using System.IO;
using Gtk;

namespace BFRES2OBJ {
	public class MainClass {
		public static void Main(string[] args) {
			MainClass mc = new MainClass();
			if (args.Length == 2) {
				for (int i = 0; i < args.Length; i++) {
					mc.Convert (args[0], args[1]);
				}
			} else {
				Console.Write ("Not enough arguments to function!\nUsage: BFRES2OBJ.exe <BFRES> <OBJ>");
			}
			Application.Quit();
		}

		public void Convert(string inF, string outF) {
			if (inF.EndsWith ("bfres")) {
				if (!Directory.Exists (Path.GetDirectoryName (outF))) {
					Directory.CreateDirectory (Path.GetDirectoryName (outF));
				}
				BfresConverter.Convert (File.ReadAllBytes (inF), outF);
			} else {
				Console.Write ("This tool can only convert BFRES files to OBJ files!\nUsage: BFRES2OBJ.exe <BFRES> <OBJ>");
			}
		}
	}
}
