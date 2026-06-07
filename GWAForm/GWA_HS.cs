/*
 * Created by SharpDevelop.
 * User: ItsByro
 * Date: 6/6/2026
 * Time: 6:44 pm
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GWAForm
{
	public partial class GWA_HS : Form
	{
		public GWA_HS()
		{
			InitializeComponent();
		}
		
		void BtnComputeClick(object sender, EventArgs e)
		{
			int all_sub = 0;
			double total_grade = 0;	
			for (int i = 0; i < GWAtable.RowCount; i++)
			{
				if (GWAtable.Rows[i].IsNewRow)
				{
					continue;
				}
				
				if (GWAtable.Rows[i].Cells[1].Value != null)
				{
					double grade;
					if (double.TryParse(GWAtable.Rows[i].Cells[1].Value.ToString(), out grade)) 
					{
						total_grade += grade;
						all_sub++;						
					}	
				}
			}
			if (all_sub > 0) 
			{
				double FinalGwa = total_grade / all_sub;
				MessageBox.Show(string.Format("the Final Grade is {0}%.",FinalGwa.ToString("0")));
			}
			else
			{
				MessageBox.Show("Error: Check the Table.");
			}
		}
	}
}
