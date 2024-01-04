
namespace Calculadora2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.factorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numPerfectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numAmigosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numPrimoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablaMultiplicacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.factorialToolStripMenuItem,
            this.numPerfectoToolStripMenuItem,
            this.numAmigosToolStripMenuItem,
            this.numPrimoToolStripMenuItem,
            this.tablaMultiplicacionToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(66, 25);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // factorialToolStripMenuItem
            // 
            this.factorialToolStripMenuItem.Name = "factorialToolStripMenuItem";
            this.factorialToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.factorialToolStripMenuItem.Text = "Factorial";
            this.factorialToolStripMenuItem.Click += new System.EventHandler(this.factorialToolStripMenuItem_Click);
            // 
            // numPerfectoToolStripMenuItem
            // 
            this.numPerfectoToolStripMenuItem.Name = "numPerfectoToolStripMenuItem";
            this.numPerfectoToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.numPerfectoToolStripMenuItem.Text = "Num.Perfecto";
            this.numPerfectoToolStripMenuItem.Click += new System.EventHandler(this.numPerfectoToolStripMenuItem_Click);
            // 
            // numAmigosToolStripMenuItem
            // 
            this.numAmigosToolStripMenuItem.Name = "numAmigosToolStripMenuItem";
            this.numAmigosToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.numAmigosToolStripMenuItem.Text = "Num. Amigos";
            this.numAmigosToolStripMenuItem.Click += new System.EventHandler(this.numAmigosToolStripMenuItem_Click);
            // 
            // numPrimoToolStripMenuItem
            // 
            this.numPrimoToolStripMenuItem.Name = "numPrimoToolStripMenuItem";
            this.numPrimoToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.numPrimoToolStripMenuItem.Text = "Num.Primo";
            this.numPrimoToolStripMenuItem.Click += new System.EventHandler(this.numPrimoToolStripMenuItem_Click);
            // 
            // tablaMultiplicacionToolStripMenuItem
            // 
            this.tablaMultiplicacionToolStripMenuItem.Name = "tablaMultiplicacionToolStripMenuItem";
            this.tablaMultiplicacionToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.tablaMultiplicacionToolStripMenuItem.Text = "TablaMultiplicacion";
            this.tablaMultiplicacionToolStripMenuItem.Click += new System.EventHandler(this.tablaMultiplicacionToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Olive;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(701, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = global::Calculadora2.Properties.Resources._21_217291_boeing_b_17_flying_fortress_wallpaper_aircraft_wallpapers;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem factorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numPerfectoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numAmigosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numPrimoToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem tablaMultiplicacionToolStripMenuItem;
    }
}

