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
	/// Description of Form3.
	/// </summary>
	public partial class Form3 : Form
	{
		public Form3()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			txtArreglo.Text = "";
			lblMayor.Text = "Mayor:";
			lblMenor.Text = "Menor:";
			lblPromedio.Text = "Promedio:";			
		}
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			string[] partes = txtArreglo.Text.Split(',');
			
			int[] numeros = new int[partes.Length];
			
			for(int i = 0; i < partes.Length; i++)
			{
				numeros[i] = int.Parse(partes[i]);
			}
			
			int mayor = numeros[0];
			int menor = numeros[0];
			double suma = 0;
			
			for(int i = 0; i < numeros.Length; i++)
			{
				if (numeros[i] > mayor)
    			{
        			mayor = numeros[i];
    			}
    			if (numeros[i] < menor)
   				 {
       				menor = numeros[i];
    			}
    				suma = suma + numeros[i];
			}
			
			double promedio = suma / numeros.Length;

			lblMayor.Text = "Mayor: " + mayor;
			lblMenor.Text = "Menor: " + menor;
			lblPromedio.Text = "Promedio: " + promedio;
			
		}
		
		void BtnRegresarClick(object sender, EventArgs e)
		{
			Form1 menu = new Form1();
			menu.Show();
			this.Close();			
		}
	}
}
