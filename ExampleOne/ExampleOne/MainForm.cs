/*
 * Created by SharpDevelop.
 * User: user
 * Date: 03.12.2023
 * Time: 19:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ExampleOne
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
		
		public int stepMove; //Шаг перемещения метки
		
		//Перемещение метки вправо на заданное количество пикселей
		void BtnControl2Click(object sender, EventArgs e)
		{
			lblOutut.Left = lblOutut.Left + stepMove; 
		}
		
		//Задание шага перемещения метки
		void LstStepSelectedIndexChanged(object sender, EventArgs e) 
		{
			stepMove = lstStep.SelectedIndex + 1;
			txtView.Text = stepMove.ToString(); //Вывод текущего шага
		}
		
		//Перемещение метки вверх на заданное количество пикселей
		void BtnControl1Click(object sender, EventArgs e)
		{
			lblOutut.Top = lblOutut.Top - stepMove;
		}
		
		//Перемещение метки влево на заданное количество пикселей
		void BtnControl3Click(object sender, EventArgs e)
		{
			lblOutut.Left = lblOutut.Left - stepMove;
		}
		
		//Перемещение метки вниз на заданное количество пикселей
		void Button1Click(object sender, EventArgs e)
		{
			lblOutut.Top = lblOutut.Top + stepMove;
		}
	}
}
