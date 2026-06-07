/*
 * Created by SharpDevelop.
 * User: ItsByro
 * Date: 5/6/2026
 * Time: 3:32 pm
 */
namespace Grade_Converter
{
	partial class MainForm_MainMenu
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
			this.btnStart = new System.Windows.Forms.Button();
			this.lblTitle = new System.Windows.Forms.Label();
			this.rdbtnGPA = new System.Windows.Forms.RadioButton();
			this.rdbtnGWA = new System.Windows.Forms.RadioButton();
			this.lblinstruction = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnStart
			// 
			this.btnStart.BackColor = System.Drawing.SystemColors.Window;
			this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStart.Location = new System.Drawing.Point(123, 306);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(152, 64);
			this.btnStart.TabIndex = 0;
			this.btnStart.Text = "Start!";
			this.btnStart.UseVisualStyleBackColor = false;
			this.btnStart.Click += new System.EventHandler(this.BtnStartClick);
			// 
			// lblTitle
			// 
			this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblTitle.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(75, 20);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(252, 115);
			this.lblTitle.TabIndex = 1;
			this.lblTitle.Text = "Grade Converter ";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// rdbtnGPA
			// 
			this.rdbtnGPA.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbtnGPA.Location = new System.Drawing.Point(123, 196);
			this.rdbtnGPA.Name = "rdbtnGPA";
			this.rdbtnGPA.Size = new System.Drawing.Size(127, 44);
			this.rdbtnGPA.TabIndex = 2;
			this.rdbtnGPA.TabStop = true;
			this.rdbtnGPA.Text = "GPA";
			this.rdbtnGPA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.rdbtnGPA.UseVisualStyleBackColor = true;
			// 
			// rdbtnGWA
			// 
			this.rdbtnGWA.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbtnGWA.Location = new System.Drawing.Point(123, 246);
			this.rdbtnGWA.Name = "rdbtnGWA";
			this.rdbtnGWA.Size = new System.Drawing.Size(127, 36);
			this.rdbtnGWA.TabIndex = 3;
			this.rdbtnGWA.TabStop = true;
			this.rdbtnGWA.Text = "GWA";
			this.rdbtnGWA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.rdbtnGWA.UseVisualStyleBackColor = true;
			// 
			// lblinstruction
			// 
			this.lblinstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblinstruction.Location = new System.Drawing.Point(28, 158);
			this.lblinstruction.Name = "lblinstruction";
			this.lblinstruction.Size = new System.Drawing.Size(348, 50);
			this.lblinstruction.TabIndex = 4;
			this.lblinstruction.Text = "Choose your Preferred Grade Conversion";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(-3, 373);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "ItsByro";
			// 
			// MainForm_MainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(403, 394);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblinstruction);
			this.Controls.Add(this.rdbtnGWA);
			this.Controls.Add(this.rdbtnGPA);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.btnStart);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "MainForm_MainMenu";
			this.Text = "Grade-Converter";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblinstruction;
		public System.Windows.Forms.RadioButton rdbtnGWA;
		public System.Windows.Forms.RadioButton rdbtnGPA;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Button btnStart;
	}
}
