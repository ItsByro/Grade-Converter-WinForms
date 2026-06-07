/*
 * Created by SharpDevelop.
 * User: ItsByro
 * Date: 6/6/2026
 * Time: 6:45 pm
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GWAForm
{
	public partial class GWA_College : Form
	{
		public GWA_College()
		{
			InitializeComponent();
		}
		
		void BtnComputeClick(object sender, EventArgs e)
		{
			double Total_WeightedGrades = 0;
			double Total_Units = 0;
			
			for (int i = 0; i < GWAtable_College.RowCount; i++) 
			{
				double grades = 0;
				double units = 0;
				
				if (GWAtable_College.Rows[i].IsNewRow) 
				{
					continue;	
				}
				
				if (GWAtable_College.Rows[i].Cells[1].Value != null && GWAtable_College.Rows[i].Cells[2].Value != null) 
				{
					string HasGrade = GWAtable_College.Rows[i].Cells[1].Value.ToString();
					string HasUnit = GWAtable_College.Rows[i].Cells[2].Value.ToString();
					
					bool Grades = double.TryParse(HasGrade, out grades);
					bool Units = double.TryParse(HasUnit, out units);
					
					if (Grades && Units) 
					{
						Total_WeightedGrades += (grades * units);
						Total_Units += units;
					}
				}
			}
			
			if (Total_Units > 0) 
			{
				double FinalGWA = Total_WeightedGrades / Total_Units;
				MessageBox.Show(string.Format("The GWA is {0}.", FinalGWA.ToString("0.00")));
			}
			else
			{
				MessageBox.Show("ERROR: Check the Table?");
			}
			
		}
	}
}
