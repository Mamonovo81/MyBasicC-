/*
 * Created by SharpDevelop.
 * User: user
 * Date: 03.12.2023
 * Time: 19:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ExampleOne
{
	partial class MainForm
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
			this.lblOutut = new System.Windows.Forms.Label();
			this.btnControl1 = new System.Windows.Forms.Button();
			this.btnControl2 = new System.Windows.Forms.Button();
			this.btnControl3 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.lstStep = new System.Windows.Forms.ListBox();
			this.txtView = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblOutut
			// 
			this.lblOutut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblOutut.Location = new System.Drawing.Point(219, 136);
			this.lblOutut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblOutut.Name = "lblOutut";
			this.lblOutut.Size = new System.Drawing.Size(85, 46);
			this.lblOutut.TabIndex = 0;
			this.lblOutut.Text = "2023";
			this.lblOutut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnControl1
			// 
			this.btnControl1.Font = new System.Drawing.Font("Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
			this.btnControl1.ForeColor = System.Drawing.Color.Maroon;
			this.btnControl1.Location = new System.Drawing.Point(60, 32);
			this.btnControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnControl1.Name = "btnControl1";
			this.btnControl1.Size = new System.Drawing.Size(52, 46);
			this.btnControl1.TabIndex = 1;
			this.btnControl1.Text = "­";
			this.btnControl1.UseVisualStyleBackColor = true;
			this.btnControl1.Click += new System.EventHandler(this.BtnControl1Click);
			// 
			// btnControl2
			// 
			this.btnControl2.Font = new System.Drawing.Font("Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
			this.btnControl2.ForeColor = System.Drawing.Color.ForestGreen;
			this.btnControl2.Location = new System.Drawing.Point(60, 88);
			this.btnControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnControl2.Name = "btnControl2";
			this.btnControl2.Size = new System.Drawing.Size(52, 49);
			this.btnControl2.TabIndex = 2;
			this.btnControl2.Text = "®";
			this.btnControl2.UseVisualStyleBackColor = true;
			this.btnControl2.Click += new System.EventHandler(this.BtnControl2Click);
			// 
			// btnControl3
			// 
			this.btnControl3.Font = new System.Drawing.Font("Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
			this.btnControl3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.btnControl3.Location = new System.Drawing.Point(60, 156);
			this.btnControl3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnControl3.Name = "btnControl3";
			this.btnControl3.Size = new System.Drawing.Size(52, 54);
			this.btnControl3.TabIndex = 3;
			this.btnControl3.Text = "¬";
			this.btnControl3.UseVisualStyleBackColor = true;
			this.btnControl3.Click += new System.EventHandler(this.BtnControl3Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Wingdings 3", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
			this.button1.ForeColor = System.Drawing.Color.Maroon;
			this.button1.Location = new System.Drawing.Point(60, 227);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(52, 46);
			this.button1.TabIndex = 4;
			this.button1.Text = "$";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// lstStep
			// 
			this.lstStep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.lstStep.FormattingEnabled = true;
			this.lstStep.ItemHeight = 20;
			this.lstStep.Items.AddRange(new object[] {
									"1",
									"2",
									"3"});
			this.lstStep.Location = new System.Drawing.Point(382, 66);
			this.lstStep.Name = "lstStep";
			this.lstStep.Size = new System.Drawing.Size(35, 64);
			this.lstStep.TabIndex = 5;
			this.lstStep.SelectedIndexChanged += new System.EventHandler(this.LstStepSelectedIndexChanged);
			// 
			// txtView
			// 
			this.txtView.Location = new System.Drawing.Point(199, 36);
			this.txtView.Name = "txtView";
			this.txtView.Size = new System.Drawing.Size(94, 26);
			this.txtView.TabIndex = 6;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 370);
			this.Controls.Add(this.txtView);
			this.Controls.Add(this.lstStep);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnControl3);
			this.Controls.Add(this.btnControl2);
			this.Controls.Add(this.btnControl1);
			this.Controls.Add(this.lblOutut);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "MainForm";
			this.Text = "ExampleOne";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtView;
		private System.Windows.Forms.ListBox lstStep;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnControl3;
		private System.Windows.Forms.Button btnControl2;
		private System.Windows.Forms.Button btnControl1;
		private System.Windows.Forms.Label lblOutut;
	}
}
