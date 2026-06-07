/*
 * Created by SharpDevelop.
 * User: ItsByro
 * Date: 5/6/2026
 * Time: 3:58 pm
 */
namespace GWAForm
{
	partial class MainFormGWA
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
			this.label2 = new System.Windows.Forms.Label();
			this.btnGWA_HS = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnGWA_C = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(3, 277);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "ItsByro";
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// btnGWA_HS
			// 
			this.btnGWA_HS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGWA_HS.Location = new System.Drawing.Point(79, 87);
			this.btnGWA_HS.Name = "btnGWA_HS";
			this.btnGWA_HS.Size = new System.Drawing.Size(213, 77);
			this.btnGWA_HS.TabIndex = 6;
			this.btnGWA_HS.Text = "Highschool/ SHS";
			this.btnGWA_HS.UseVisualStyleBackColor = true;
			this.btnGWA_HS.Click += new System.EventHandler(this.BtnGWA_HSClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(64, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(239, 34);
			this.label1.TabIndex = 7;
			this.label1.Text = "Choose Between: ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnGWA_C
			// 
			this.btnGWA_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGWA_C.Location = new System.Drawing.Point(79, 185);
			this.btnGWA_C.Name = "btnGWA_C";
			this.btnGWA_C.Size = new System.Drawing.Size(213, 77);
			this.btnGWA_C.TabIndex = 8;
			this.btnGWA_C.Text = "College";
			this.btnGWA_C.UseVisualStyleBackColor = true;
			this.btnGWA_C.Click += new System.EventHandler(this.BtnGWA_CClick);
			// 
			// MainFormGWA
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(366, 300);
			this.Controls.Add(this.btnGWA_C);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnGWA_HS);
			this.Controls.Add(this.label2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "MainFormGWA";
			this.Text = "GWAForm";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnGWA_C;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnGWA_HS;
		private System.Windows.Forms.Label label2;
	}
}
