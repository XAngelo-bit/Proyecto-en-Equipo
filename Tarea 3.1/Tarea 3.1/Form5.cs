/*
 * Created by SharpDevelop.
 * User: CC2_PC47
 * Date: 25/11/2026
 * Time: 08:03 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tarea_3._
{
	/// <summary>
	/// Description of Form5.
	/// </summary>
	public partial class Form5 : Form
	{
		public Form5()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void SalirDelProgramaToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void SalirToolStripMenuItemClick(object sender, EventArgs e)
		{
			Form1 menu = new Form1();
			menu.Show();
			this.Close();
		}
		
		void LimpiarCamposToolStripMenuItemClick(object sender, EventArgs e)
		{
			textBox1.Text="";			
			textBox2.Text="";
			textBox3.Text="";
		}
	}
}
