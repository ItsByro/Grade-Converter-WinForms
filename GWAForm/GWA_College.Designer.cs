/*
 * Created by SharpDevelop.
 * User: ItsByro
 * Date: 6/6/2026
 * Time: 6:45 pm
 */
namespace GWAForm
{
	partial class GWA_College
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
			this.label1 = new System.Windows.Forms.Label();
			this.GWAtable_College = new System.Windows.Forms.DataGridView();
			this.Subjects = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Grades = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnCompute = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.GWAtable_College)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(42, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(512, 42);
			this.label1.TabIndex = 2;
			this.label1.Text = "GWA Conversion [College]";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// GWAtable_College
			// 
			this.GWAtable_College.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.GWAtable_College.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GWAtable_College.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Subjects,
									this.Grades,
									this.Unit});
			this.GWAtable_College.Location = new System.Drawing.Point(42, 78);
			this.GWAtable_College.Name = "GWAtable_College";
			this.GWAtable_College.RowTemplate.Height = 28;
			this.GWAtable_College.Size = new System.Drawing.Size(512, 192);
			this.GWAtable_College.TabIndex = 3;
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
			// btnCompute
			// 
			this.btnCompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCompute.Location = new System.Drawing.Point(576, 186);
			this.btnCompute.Name = "btnCompute";
			this.btnCompute.Size = new System.Drawing.Size(124, 84);
			this.btnCompute.TabIndex = 4;
			this.btnCompute.Text = "Compute";
			this.btnCompute.UseVisualStyleBackColor = true;
			this.btnCompute.Click += new System.EventHandler(this.BtnComputeClick);
			// 
			// GWA_College
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(723, 300);
			this.Controls.Add(this.btnCompute);
			this.Controls.Add(this.GWAtable_College);
			this.Controls.Add(this.label1);
			this.Name = "GWA_College";
			this.Text = "GWA_College";
			((System.ComponentModel.ISupportInitialize)(this.GWAtable_College)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnCompute;
		private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
		private System.Windows.Forms.DataGridViewTextBoxColumn Grades;
		private System.Windows.Forms.DataGridViewTextBoxColumn Subjects;
		public System.Windows.Forms.DataGridView GWAtable_College;
		private System.Windows.Forms.Label label1;
	}
}
