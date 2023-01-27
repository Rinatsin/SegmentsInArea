﻿using DevExpress.UserSkins;
using System;
using System.Windows.Forms;

namespace SegmentsInArea
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			BonusSkins.Register();
			Application.Run(new Form1());
		}
	}
}