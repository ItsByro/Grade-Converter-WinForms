/*
 * Created by SharpDevelop.
 * User: ItsByro
 * Date: 5/6/2026
 * Time: 3:33 pm
 */
using System;
using System.Windows.Forms;

namespace GPAForm
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainFormGPA());
		}
		
	}
}
