namespace UI
{
    partial class Form_Banner
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_Banners = new System.Windows.Forms.DataGridView();
            this.button_Agregar = new System.Windows.Forms.Button();
            this.button_Eliminar = new System.Windows.Forms.Button();
            this.button_Aceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Banners)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(602, 83);
            this.label1.TabIndex = 0;
            this.label1.Text = "Banners";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView_Banners
            // 
            this.dataGridView_Banners.AllowUserToAddRows = false;
            this.dataGridView_Banners.AllowUserToDeleteRows = false;
            this.dataGridView_Banners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Banners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Banners.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_Banners.Location = new System.Drawing.Point(0, 115);
            this.dataGridView_Banners.MultiSelect = false;
            this.dataGridView_Banners.Name = "dataGridView_Banners";
            this.dataGridView_Banners.ReadOnly = true;
            this.dataGridView_Banners.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_Banners.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Banners.Size = new System.Drawing.Size(602, 161);
            this.dataGridView_Banners.TabIndex = 2;
            this.dataGridView_Banners.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button_Agregar
            // 
            this.button_Agregar.Location = new System.Drawing.Point(434, 86);
            this.button_Agregar.Name = "button_Agregar";
            this.button_Agregar.Size = new System.Drawing.Size(75, 23);
            this.button_Agregar.TabIndex = 3;
            this.button_Agregar.Text = "Agregar";
            this.button_Agregar.UseVisualStyleBackColor = true;
            this.button_Agregar.Click += new System.EventHandler(this.button_Agregar_Click);
            // 
            // button_Eliminar
            // 
            this.button_Eliminar.Location = new System.Drawing.Point(515, 86);
            this.button_Eliminar.Name = "button_Eliminar";
            this.button_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.button_Eliminar.TabIndex = 4;
            this.button_Eliminar.Text = "Eliminar";
            this.button_Eliminar.UseVisualStyleBackColor = true;
            this.button_Eliminar.Click += new System.EventHandler(this.button_Eliminar_Click);
            // 
            // button_Aceptar
            // 
            this.button_Aceptar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_Aceptar.Location = new System.Drawing.Point(0, 276);
            this.button_Aceptar.Name = "button_Aceptar";
            this.button_Aceptar.Size = new System.Drawing.Size(602, 42);
            this.button_Aceptar.TabIndex = 5;
            this.button_Aceptar.Text = "Aceptar";
            this.button_Aceptar.UseVisualStyleBackColor = true;
            this.button_Aceptar.Click += new System.EventHandler(this.button_Aceptar_Click);
            // 
            // Form_Banner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 318);
            this.Controls.Add(this.button_Eliminar);
            this.Controls.Add(this.button_Agregar);
            this.Controls.Add(this.dataGridView_Banners);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Aceptar);
            this.Name = "Form_Banner";
            this.Text = "Form_Banner";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Banners)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_Banners;
        private System.Windows.Forms.Button button_Agregar;
        private System.Windows.Forms.Button button_Eliminar;
        private System.Windows.Forms.Button button_Aceptar;
    }
}