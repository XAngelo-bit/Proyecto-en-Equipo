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
	partial class Form5
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.calcularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.limpiarCamposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salirDelProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.AliceBlue;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.calcularToolStripMenuItem,
									this.limpiarCamposToolStripMenuItem,
									this.salirToolStripMenuItem,
									this.salirDelProgramaToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(543, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// calcularToolStripMenuItem
			// 
			this.calcularToolStripMenuItem.Name = "calcularToolStripMenuItem";
			this.calcularToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
			this.calcularToolStripMenuItem.Text = "Calcular";
			// 
			// limpiarCamposToolStripMenuItem
			// 
			this.limpiarCamposToolStripMenuItem.Name = "limpiarCamposToolStripMenuItem";
			this.limpiarCamposToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
			this.limpiarCamposToolStripMenuItem.Text = "Limpiar Campos";
			this.limpiarCamposToolStripMenuItem.Click += new System.EventHandler(this.LimpiarCamposToolStripMenuItemClick);
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
			this.salirToolStripMenuItem.Text = "Regresar al Inicio";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItemClick);
			// 
			// salirDelProgramaToolStripMenuItem
			// 
			this.salirDelProgramaToolStripMenuItem.Name = "salirDelProgramaToolStripMenuItem";
			this.salirDelProgramaToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
			this.salirDelProgramaToolStripMenuItem.Text = "Salir del Programa";
			this.salirDelProgramaToolStripMenuItem.Click += new System.EventHandler(this.SalirDelProgramaToolStripMenuItemClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(172, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Ingresa una Palabra:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(13, 62);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(308, 20);
			this.textBox1.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(123, 142);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(172, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "La Palabra Tiene:";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label3.Location = new System.Drawing.Point(149, 165);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Vocales:";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label4.Location = new System.Drawing.Point(146, 188);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(127, 23);
			this.label4.TabIndex = 5;
			this.label4.Text = "Consonantes:";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(228, 168);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(111, 20);
			this.textBox2.TabIndex = 6;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(264, 191);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(75, 20);
			this.textBox3.TabIndex = 7;
			// 
			// Form5
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Snow;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(543, 317);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.DoubleBuffered = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form5";
			this.Text = "Form5";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ToolStripMenuItem salirDelProgramaToolStripMenuItem;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem limpiarCamposToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem calcularToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
