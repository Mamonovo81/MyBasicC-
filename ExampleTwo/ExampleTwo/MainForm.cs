/*
 * Created by SharpDevelop.
 * User: user
 * Date: 03.12.2023
 * Time: 23:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ExampleTwo
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		//Подготовительные действия при запуске программ
		void MainFormActivated(object sender, EventArgs e)
		{
			btnNumber1.Visible = false; //Первая кнопка невидима
			vsbMove.Value =  1; //Ползунок линейки прокрутки стоит на первой позиции
			txtOut.Text = "1"; //Начальной начение редактора
		}
		
		//Последовательное сокрытие кнопок с добавлением их номеров в редактор
		void VsbMoveScroll(object sender, ScrollEventArgs e)
		{
			if ((int)e.Type == 8) // Устранение дребезжания ползунка
			{
				//На каждом шаге сначала все кнопки становятся видимыми
				btnNumber1.Visible = true;
				btnNumber2.Visible = true;
				btnNumber3.Visible = true;
				btnNumber4.Visible = true;
				btnNumber5.Visible = true;
				btnNumber6.Visible = true;	
				//Выбранная кнопка становится невидимой
				if (vsbMove.Value ==  1)
					btnNumber1.Visible = false;
				if (vsbMove.Value ==  2)
					btnNumber2.Visible = false;	
				if (vsbMove.Value ==  3)
					btnNumber3.Visible = false;
				if (vsbMove.Value ==  4)
					btnNumber4.Visible = false;	
				if (vsbMove.Value ==  5)
					btnNumber5.Visible = false;
				if (vsbMove.Value ==  6)
					btnNumber6.Visible = false;	
				txtOut.Text += vsbMove.Value.ToString();
			}
		}
		
		//Очистка редактора
		void BtnClearClick(object sender, EventArgs e)
		{
			txtOut.Text = "";
		}
	}
}
