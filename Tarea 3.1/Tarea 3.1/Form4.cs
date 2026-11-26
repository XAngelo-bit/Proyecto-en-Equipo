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
	/// Description of Form4.
	/// </summary>
	public partial class Form4 : Form
	{
		public Form4()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			string palabra = textBox1.Text;
         	char[] letras = palabra.ToCharArray();
         	Array.Reverse(letras);
         	textBox2.Text = new string(letras);			
		}
	}
}
