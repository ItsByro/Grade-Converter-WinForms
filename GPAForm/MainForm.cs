/*
 * Created by SharpDevelop.
 * User: ItsByro
 * Date: 5/6/2026
 * Time: 6:47 am
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GPAForm
{
	public partial class MainFormGPA : Form
	{
		public MainFormGPA()
		{
			InitializeComponent();
		}
		
		//Easter Egg
		void Label2Click(object sender, EventArgs e)
		{	
			MessageBox.Show("0H lo0k 4n Easter_Egg::");
		}
		
		void BtnComputeClick(object sender, EventArgs e)
		{
			double Total_WeightedGrade = 0;
			double Total_Unit = 0;
			
			for (int i = 0; i < GPAtable.RowCount; i++) 
			{
				double grade = 0;
				double units = 0;
				
				//ignore the newly added created table
				if (GPAtable.Rows[i].IsNewRow)
				{
					continue;	
				}
				//Logic
				if (GPAtable.Rows[i].Cells[1].Value != null && GPAtable.Rows[i].Cells[2].Value != null)
				{
					string HasGrades = GPAtable.Rows[i].Cells[1].Value.ToString();
					string HasUnits = GPAtable.Rows[i].Cells[2].Value.ToString();
					
					bool Grades = double.TryParse(HasGrades, out grade);
					bool Units = double.TryParse(HasUnits, out units);
					
					if (Grades && Units) 
					{
						Total_WeightedGrade += (grade * units);
						Total_Unit += units;
					}
				}
			}
			if (Total_Unit > 0) 
			{
				double GPA = Total_WeightedGrade / Total_Unit;
				MessageBox.Show(string.Format("The GPA is {0}.", GPA.ToString("0.00")));
			}
			else
			{
				MessageBox.Show("Error: Check the Table");
			}
		}
	}
}
