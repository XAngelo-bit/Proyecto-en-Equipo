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
		
		void BtnSalirClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			string[] datos = txtDatos.Text.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
			double[] numeros = new double[datos.Length];
			double suma = 0;
			
			for (int i = 0; i < datos.Length; i++)
			{
				numeros[i] = Convert.ToDouble(datos[i]);
				suma = suma + numeros[i];
			}

			Array.Sort(numeros);
		
			double menor = numeros[0];
			double mayor = numeros[numeros.Length - 1];
			double promedio = suma / numeros.Length;
		
			string menorAMayor = "";
			for (int i = 0; i < numeros.Length; i++)
			{
				menorAMayor = menorAMayor + numeros[i] + " ";
			}
		
			string mayorAMenor = "";
			for (int i = numeros.Length - 1; i >= 0; i--)
			{
				mayorAMenor = mayorAMenor + numeros[i] + " ";
			}
		
			lblMayor.Text = "Mayor : " + mayor + "  (" + mayorAMenor + ")";
			lblPromedio.Text = "Promedio : " + promedio;
			lblMenor.Text = "Menor : " + menor + "  (" + menorAMayor + ")";
		}
	}
}
