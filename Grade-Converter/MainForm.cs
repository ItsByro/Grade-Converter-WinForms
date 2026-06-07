/*
 * Created by SharpDevelop.
 * User: ItsByro
 * Date: 5/5/2026
 * Time: 11:52 am
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GPAForm;
using GWAForm;

namespace Grade_Converter
{
	public partial class MainForm_MainMenu : Form
	{
		public MainForm_MainMenu()
		{
			InitializeComponent();
			
		}
		void BtnStartClick(object sender, EventArgs e)
		{	
			if (rdbtnGPA.Checked) 
			{
				MainFormGPA formGPA = new MainFormGPA();
				formGPA.FormClosed += (s, args) => this.Show();
				formGPA.Show();
				this.Hide();
			}
			else if (rdbtnGWA.Checked)
			{
				MainFormGWA formGWA = new MainFormGWA();
				formGWA.FormClosed += (s, args) => this.Show();
				formGWA.Show();
				this.Hide();
			}
			else 
			{
				MessageBox.Show("Please choose between the choices.");
			}
		}
	}
}
