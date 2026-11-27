/*
 * Created by SharpDevelop.
 * User: CC2_PC47
 * Date: 25/11/2026
 * Time: 08:03 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Tarea_3._
{
	partial class Form3
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
			this.txtArreglo = new System.Windows.Forms.TextBox();
			this.lblArreglo = new System.Windows.Forms.Label();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.lblMayor = new System.Windows.Forms.Label();
			this.lblPromedio = new System.Windows.Forms.Label();
			this.lblMenor = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtArreglo
			// 
			this.txtArreglo.Location = new System.Drawing.Point(118, 42);
			this.txtArreglo.Name = "txtArreglo";
			this.txtArreglo.Size = new System.Drawing.Size(189, 20);
			this.txtArreglo.TabIndex = 0;
			// 
			// lblArreglo
			// 
			this.lblArreglo.Location = new System.Drawing.Point(12, 39);
			this.lblArreglo.Name = "lblArreglo";
			this.lblArreglo.Size = new System.Drawing.Size(100, 23);
			this.lblArreglo.TabIndex = 1;
			this.lblArreglo.Text = "Arreglo:";
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(13, 286);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(99, 43);
			this.btnCalcular.TabIndex = 2;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// btnRegresar
			// 
			this.btnRegresar.Location = new System.Drawing.Point(336, 286);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(85, 43);
			this.btnRegresar.TabIndex = 3;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = true;
			this.btnRegresar.Click += new System.EventHandler(this.BtnRegresarClick);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(177, 286);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(94, 43);
			this.btnLimpiar.TabIndex = 4;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.Button3Click);
			// 
			// lblMayor
			// 
			this.lblMayor.Location = new System.Drawing.Point(13, 105);
			this.lblMayor.Name = "lblMayor";
			this.lblMayor.Size = new System.Drawing.Size(100, 23);
			this.lblMayor.TabIndex = 5;
			this.lblMayor.Text = "Mayor:";
			// 
			// lblPromedio
			// 
			this.lblPromedio.Location = new System.Drawing.Point(13, 222);
			this.lblPromedio.Name = "lblPromedio";
			this.lblPromedio.Size = new System.Drawing.Size(100, 23);
			this.lblPromedio.TabIndex = 6;
			this.lblPromedio.Text = "Promedio:";
			// 
			// lblMenor
			// 
			this.lblMenor.Location = new System.Drawing.Point(12, 166);
			this.lblMenor.Name = "lblMenor";
			this.lblMenor.Size = new System.Drawing.Size(100, 23);
			this.lblMenor.TabIndex = 7;
			this.lblMenor.Text = "Menor:";
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(442, 341);
			this.Controls.Add(this.lblMenor);
			this.Controls.Add(this.lblPromedio);
			this.Controls.Add(this.lblMayor);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.lblArreglo);
			this.Controls.Add(this.txtArreglo);
			this.Name = "Form3";
			this.Text = "Form3";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblMenor;
		private System.Windows.Forms.Label lblPromedio;
		private System.Windows.Forms.Label lblMayor;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnRegresar;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Label lblArreglo;
		private System.Windows.Forms.TextBox txtArreglo;
	}
}
