﻿namespace UI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.campañaPublicitariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bannerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónContextualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.configuraciónToolStripMenuItem,
            this.vistaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.campañaPublicitariaToolStripMenuItem,
            this.bannerToolStripMenuItem,
            this.informaciónContextualToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // vistaToolStripMenuItem
            // 
            this.vistaToolStripMenuItem.Name = "vistaToolStripMenuItem";
            this.vistaToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.vistaToolStripMenuItem.Text = "Vista";
            // 
            // campañaPublicitariaToolStripMenuItem
            // 
            this.campañaPublicitariaToolStripMenuItem.Name = "campañaPublicitariaToolStripMenuItem";
            this.campañaPublicitariaToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.campañaPublicitariaToolStripMenuItem.Text = "Campaña publicitaria";
            // 
            // bannerToolStripMenuItem
            // 
            this.bannerToolStripMenuItem.Name = "bannerToolStripMenuItem";
            this.bannerToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.bannerToolStripMenuItem.Text = "Banner";
            this.bannerToolStripMenuItem.Click += new System.EventHandler(this.bannerToolStripMenuItem_Click);
            // 
            // informaciónContextualToolStripMenuItem
            // 
            this.informaciónContextualToolStripMenuItem.Name = "informaciónContextualToolStripMenuItem";
            this.informaciónContextualToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.informaciónContextualToolStripMenuItem.Text = "Información contextual";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cartelería Digital";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem campañaPublicitariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bannerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaciónContextualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vistaToolStripMenuItem;
    }
}

