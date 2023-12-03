/*
 * Created by SharpDevelop.
 * User: user
 * Date: 03.12.2023
 * Time: 23:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ExampleTwo
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
			this.btnNumber1 = new System.Windows.Forms.Button();
			this.btnNumber2 = new System.Windows.Forms.Button();
			this.btnNumber3 = new System.Windows.Forms.Button();
			this.btnNumber4 = new System.Windows.Forms.Button();
			this.btnNumber5 = new System.Windows.Forms.Button();
			this.btnNumber6 = new System.Windows.Forms.Button();
			this.vsbMove = new System.Windows.Forms.VScrollBar();
			this.txtOut = new System.Windows.Forms.TextBox();
			this.btnClear = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnNumber1
			// 
			this.btnNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnNumber1.ForeColor = System.Drawing.Color.Navy;
			this.btnNumber1.Location = new System.Drawing.Point(26, 13);
			this.btnNumber1.Name = "btnNumber1";
			this.btnNumber1.Size = new System.Drawing.Size(46, 41);
			this.btnNumber1.TabIndex = 0;
			this.btnNumber1.Text = "1";
			this.btnNumber1.UseVisualStyleBackColor = true;
			// 
			// btnNumber2
			// 
			this.btnNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnNumber2.ForeColor = System.Drawing.Color.Navy;
			this.btnNumber2.Location = new System.Drawing.Point(26, 60);
			this.btnNumber2.Name = "btnNumber2";
			this.btnNumber2.Size = new System.Drawing.Size(46, 41);
			this.btnNumber2.TabIndex = 1;
			this.btnNumber2.Text = "2";
			this.btnNumber2.UseVisualStyleBackColor = true;
			// 
			// btnNumber3
			// 
			this.btnNumber3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnNumber3.ForeColor = System.Drawing.Color.Navy;
			this.btnNumber3.Location = new System.Drawing.Point(26, 107);
			this.btnNumber3.Name = "btnNumber3";
			this.btnNumber3.Size = new System.Drawing.Size(46, 41);
			this.btnNumber3.TabIndex = 2;
			this.btnNumber3.Text = "3";
			this.btnNumber3.UseVisualStyleBackColor = true;
			// 
			// btnNumber4
			// 
			this.btnNumber4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnNumber4.ForeColor = System.Drawing.Color.Navy;
			this.btnNumber4.Location = new System.Drawing.Point(26, 154);
			this.btnNumber4.Name = "btnNumber4";
			this.btnNumber4.Size = new System.Drawing.Size(46, 41);
			this.btnNumber4.TabIndex = 3;
			this.btnNumber4.Text = "4";
			this.btnNumber4.UseVisualStyleBackColor = true;
			// 
			// btnNumber5
			// 
			this.btnNumber5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnNumber5.ForeColor = System.Drawing.Color.Navy;
			this.btnNumber5.Location = new System.Drawing.Point(26, 201);
			this.btnNumber5.Name = "btnNumber5";
			this.btnNumber5.Size = new System.Drawing.Size(46, 41);
			this.btnNumber5.TabIndex = 4;
			this.btnNumber5.Text = "5";
			this.btnNumber5.UseVisualStyleBackColor = true;
			// 
			// btnNumber6
			// 
			this.btnNumber6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnNumber6.ForeColor = System.Drawing.Color.Navy;
			this.btnNumber6.Location = new System.Drawing.Point(26, 248);
			this.btnNumber6.Name = "btnNumber6";
			this.btnNumber6.Size = new System.Drawing.Size(46, 41);
			this.btnNumber6.TabIndex = 5;
			this.btnNumber6.Text = "6";
			this.btnNumber6.UseVisualStyleBackColor = true;
			// 
			// vsbMove
			// 
			this.vsbMove.LargeChange = 1;
			this.vsbMove.Location = new System.Drawing.Point(93, 0);
			this.vsbMove.Maximum = 6;
			this.vsbMove.Minimum = 1;
			this.vsbMove.Name = "vsbMove";
			this.vsbMove.Size = new System.Drawing.Size(25, 305);
			this.vsbMove.TabIndex = 6;
			this.vsbMove.Value = 1;
			this.vsbMove.Scroll += new System.Windows.Forms.ScrollEventHandler(this.VsbMoveScroll);
			// 
			// txtOut
			// 
			this.txtOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtOut.Location = new System.Drawing.Point(177, 128);
			this.txtOut.Name = "txtOut";
			this.txtOut.Size = new System.Drawing.Size(120, 29);
			this.txtOut.TabIndex = 7;
			// 
			// btnClear
			// 
			this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnClear.Location = new System.Drawing.Point(182, 214);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(105, 34);
			this.btnClear.TabIndex = 8;
			this.btnClear.Text = "Очистка";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.BtnClearClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(356, 314);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.txtOut);
			this.Controls.Add(this.vsbMove);
			this.Controls.Add(this.btnNumber6);
			this.Controls.Add(this.btnNumber5);
			this.Controls.Add(this.btnNumber4);
			this.Controls.Add(this.btnNumber3);
			this.Controls.Add(this.btnNumber2);
			this.Controls.Add(this.btnNumber1);
			this.Name = "MainForm";
			this.Text = "ExampleTwo";
			this.Activated += new System.EventHandler(this.MainFormActivated);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.TextBox txtOut;
		private System.Windows.Forms.VScrollBar vsbMove;
		private System.Windows.Forms.Button btnNumber6;
		private System.Windows.Forms.Button btnNumber5;
		private System.Windows.Forms.Button btnNumber4;
		private System.Windows.Forms.Button btnNumber3;
		private System.Windows.Forms.Button btnNumber2;
		private System.Windows.Forms.Button btnNumber1;
	}
}
