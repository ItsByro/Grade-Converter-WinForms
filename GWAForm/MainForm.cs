/*
 * Created by SharpDevelop.
 * User: ItsByro
 * Date: 5/6/2026
 * Time: 3:58 pm
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace GWAForm
{
	public partial class MainFormGWA : Form
	{
		public MainFormGWA()
		{
			InitializeComponent();	
		}
		
		void Label2Click(object sender, EventArgs e)
		{
			MessageBox.Show("H3he, 3asTer=Eg!");
		}
		
		void BtnGWA_HSClick(object sender, EventArgs e)
		{
			GWA_HS HighschoolForm = new GWA_HS();
			HighschoolForm.FormClosed += (s, args) => this.Close();
			HighschoolForm.Show();
			this.Hide();
		}
		
		void BtnGWA_CClick(object sender, EventArgs e)
		{
			GWA_College CollegeForm = new GWA_College();
			CollegeForm.FormClosed += (s, args) => this.Close();
			CollegeForm.Show();
			this.Hide();
		}
	}
}
