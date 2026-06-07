/*
 * Created by SharpDevelop.
 * User: ItsByro
 * Date: 5/6/2026
 * Time: 3:33 pm
 */
namespace GPAForm
{
	partial class MainFormGPA
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.GPAtable = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.btnCompute = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.Subjects = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Grades = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.GPAtable)).BeginInit();
			this.SuspendLayout();
			// 
			// GPAtable
			// 
			this.GPAtable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.GPAtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GPAtable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Subjects,
									this.Grades,
									this.Unit});
			this.GPAtable.Location = new System.Drawing.Point(42, 78);
			this.GPAtable.Name = "GPAtable";
			this.GPAtable.RowTemplate.Height = 28;
			this.GPAtable.Size = new System.Drawing.Size(512, 192);
			this.GPAtable.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(42, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(512, 42);
			this.label1.TabIndex = 1;
			this.label1.Text = "GPA Conversion";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnCompute
			// 
			this.btnCompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCompute.Location = new System.Drawing.Point(589, 186);
			this.btnCompute.Name = "btnCompute";
			this.btnCompute.Size = new System.Drawing.Size(124, 84);
			this.btnCompute.TabIndex = 2;
			this.btnCompute.Text = "Compute";
			this.btnCompute.UseVisualStyleBackColor = true;
			this.btnCompute.Click += new System.EventHandler(this.BtnComputeClick);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(677, -1);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "ItsByro";
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// Subjects
			// 
			this.Subjects.HeaderText = "Subject";
			this.Subjects.Name = "Subjects";
			// 
			// Grades
			// 
			this.Grades.HeaderText = "Grade";
			this.Grades.Name = "Grades";
			// 
			// Unit
			// 
			this.Unit.HeaderText = "Units";
			this.Unit.Name = "Unit";
			// 
			// MainFormGPA
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(735, 312);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnCompute);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.GPAtable);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "MainFormGPA";
			this.Text = "GPAForm";
			((System.ComponentModel.ISupportInitialize)(this.GPAtable)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn Grades;
		private System.Windows.Forms.DataGridViewTextBoxColumn Subjects;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnCompute;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
		public System.Windows.Forms.DataGridView GPAtable;
	}
}
