/*
 * Created by SharpDevelop.
 * User: CC2_PC47
 * Date: 25/11/2026
 * Time: 07:47 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Tarea_3._
{
	partial class Form1
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.ordenarArregloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.modaMediaYMedianaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.palabraAlRevésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.vocalesYConsonantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.regresarAInicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(294, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(201, 192);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.Maroon;
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
			this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.ordenarArregloToolStripMenuItem,
									this.modaMediaYMedianaToolStripMenuItem,
									this.palabraAlRevésToolStripMenuItem,
									this.vocalesYConsonantesToolStripMenuItem,
									this.regresarAInicioToolStripMenuItem,
									this.acercaDeToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(150, 317);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// ordenarArregloToolStripMenuItem
			// 
			this.ordenarArregloToolStripMenuItem.ForeColor = System.Drawing.Color.Ivory;
			this.ordenarArregloToolStripMenuItem.Name = "ordenarArregloToolStripMenuItem";
			this.ordenarArregloToolStripMenuItem.Size = new System.Drawing.Size(143, 19);
			this.ordenarArregloToolStripMenuItem.Text = "Ordenar Arreglo";
			this.ordenarArregloToolStripMenuItem.Click += new System.EventHandler(this.OrdenarArregloToolStripMenuItemClick);
			// 
			// modaMediaYMedianaToolStripMenuItem
			// 
			this.modaMediaYMedianaToolStripMenuItem.ForeColor = System.Drawing.Color.Ivory;
			this.modaMediaYMedianaToolStripMenuItem.Name = "modaMediaYMedianaToolStripMenuItem";
			this.modaMediaYMedianaToolStripMenuItem.Size = new System.Drawing.Size(143, 19);
			this.modaMediaYMedianaToolStripMenuItem.Text = "Moda, Media y Mediana";
			this.modaMediaYMedianaToolStripMenuItem.Click += new System.EventHandler(this.ModaMediaYMedianaToolStripMenuItemClick);
			// 
			// palabraAlRevésToolStripMenuItem
			// 
			this.palabraAlRevésToolStripMenuItem.ForeColor = System.Drawing.Color.Ivory;
			this.palabraAlRevésToolStripMenuItem.Name = "palabraAlRevésToolStripMenuItem";
			this.palabraAlRevésToolStripMenuItem.Size = new System.Drawing.Size(143, 19);
			this.palabraAlRevésToolStripMenuItem.Text = "Palabra al Revés";
			this.palabraAlRevésToolStripMenuItem.Click += new System.EventHandler(this.PalabraAlRevésToolStripMenuItemClick);
			// 
			// vocalesYConsonantesToolStripMenuItem
			// 
			this.vocalesYConsonantesToolStripMenuItem.ForeColor = System.Drawing.Color.Ivory;
			this.vocalesYConsonantesToolStripMenuItem.Name = "vocalesYConsonantesToolStripMenuItem";
			this.vocalesYConsonantesToolStripMenuItem.Size = new System.Drawing.Size(143, 19);
			this.vocalesYConsonantesToolStripMenuItem.Text = "Vocales y Consonantes";
			this.vocalesYConsonantesToolStripMenuItem.Click += new System.EventHandler(this.VocalesYConsonantesToolStripMenuItemClick);
			// 
			// regresarAInicioToolStripMenuItem
			// 
			this.regresarAInicioToolStripMenuItem.ForeColor = System.Drawing.Color.Ivory;
			this.regresarAInicioToolStripMenuItem.Name = "regresarAInicioToolStripMenuItem";
			this.regresarAInicioToolStripMenuItem.Size = new System.Drawing.Size(143, 19);
			this.regresarAInicioToolStripMenuItem.Text = "Regresar a Inicio";
			this.regresarAInicioToolStripMenuItem.Click += new System.EventHandler(this.RegresarAInicioToolStripMenuItemClick);
			// 
			// acercaDeToolStripMenuItem
			// 
			this.acercaDeToolStripMenuItem.ForeColor = System.Drawing.Color.Ivory;
			this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
			this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(143, 19);
			this.acercaDeToolStripMenuItem.Text = "Acerca De";
			this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.AcercaDeToolStripMenuItemClick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(507, 317);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem regresarAInicioToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem vocalesYConsonantesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem palabraAlRevésToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem modaMediaYMedianaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ordenarArregloToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
