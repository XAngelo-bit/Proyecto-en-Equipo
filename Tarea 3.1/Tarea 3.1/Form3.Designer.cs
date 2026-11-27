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
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lblPromedio = new System.Windows.Forms.Label();
			this.lblMenor = new System.Windows.Forms.Label();
			this.lblMayor = new System.Windows.Forms.Label();
			this.txtDatos = new System.Windows.Forms.TextBox();
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(22, 90);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(221, 36);
			this.label2.TabIndex = 15;
			this.label2.Text = "Ingresar los datos :";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(59, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(438, 44);
			this.label1.TabIndex = 14;
			this.label1.Text = "Calcular mayor, menor y promedio";
			// 
			// lblPromedio
			// 
			this.lblPromedio.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPromedio.Location = new System.Drawing.Point(131, 203);
			this.lblPromedio.Name = "lblPromedio";
			this.lblPromedio.Size = new System.Drawing.Size(241, 23);
			this.lblPromedio.TabIndex = 13;
			this.lblPromedio.Text = "Promedio :";
			// 
			// lblMenor
			// 
			this.lblMenor.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMenor.Location = new System.Drawing.Point(131, 246);
			this.lblMenor.Name = "lblMenor";
			this.lblMenor.Size = new System.Drawing.Size(241, 23);
			this.lblMenor.TabIndex = 12;
			this.lblMenor.Text = "Menor :";
			// 
			// lblMayor
			// 
			this.lblMayor.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMayor.Location = new System.Drawing.Point(131, 163);
			this.lblMayor.Name = "lblMayor";
			this.lblMayor.Size = new System.Drawing.Size(241, 23);
			this.lblMayor.TabIndex = 11;
			this.lblMayor.Text = "Mayor :";
			// 
			// txtDatos
			// 
			this.txtDatos.Location = new System.Drawing.Point(249, 90);
			this.txtDatos.Multiline = true;
			this.txtDatos.Name = "txtDatos";
			this.txtDatos.Size = new System.Drawing.Size(277, 36);
			this.txtDatos.TabIndex = 10;
			// 
			// btnSalir
			// 
			this.btnSalir.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.Location = new System.Drawing.Point(370, 317);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(156, 48);
			this.btnSalir.TabIndex = 9;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// btnCalcular
			// 
			this.btnCalcular.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalcular.Location = new System.Drawing.Point(22, 317);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(156, 48);
			this.btnCalcular.TabIndex = 8;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(549, 379);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblPromedio);
			this.Controls.Add(this.lblMenor);
			this.Controls.Add(this.lblMayor);
			this.Controls.Add(this.txtDatos);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnCalcular);
			this.Name = "Form3";
			this.Text = "Form3";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.TextBox txtDatos;
		private System.Windows.Forms.Label lblMayor;
		private System.Windows.Forms.Label lblMenor;
		private System.Windows.Forms.Label lblPromedio;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}
