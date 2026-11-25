/*
 * Created by SharpDevelop.
 * User: CC2_PC47
 * Date: 25/11/2026
 * Time: 07:47 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tarea_3._
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Form1Load(object sender, EventArgs e)
		{
			
		}
		
		void RegresarAInicioToolStripMenuItemClick(object sender, EventArgs e)
		{
			MainForm main = new MainForm();
			main.Show();
			this.Close();
		}
		
		void OrdenarArregloToolStripMenuItemClick(object sender, EventArgs e)
		{
			Form2 ordenararreglo = new Form2();
			ordenararreglo.Show();
			this.Hide();
		}
		
		void ModaMediaYMedianaToolStripMenuItemClick(object sender, EventArgs e)
		{
			Form3 media = new Form3();
			media.Show();
			this.Hide();
		}
		
		void PalabraAlRevésToolStripMenuItemClick(object sender, EventArgs e)
		{
			Form4 palabra = new Form4();
			palabra.Show();
			this.Hide();
		}
		
		void VocalesYConsonantesToolStripMenuItemClick(object sender, EventArgs e)
		{
			Form5 vocal = new Form5();
			vocal.Show();
			this.Hide();
		}
		
		void AcercaDeToolStripMenuItemClick(object sender, EventArgs e)
		{
			Form6 info = new Form6();
			info.Show();
			this.Hide();
		}
	}
}
