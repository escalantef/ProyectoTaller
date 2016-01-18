namespace UI
{
    partial class Form_Configuración_Banner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Configuración_Banner));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.radioButton_FuenteRSS = new System.Windows.Forms.RadioButton();
            this.radioButton_TextoFijo = new System.Windows.Forms.RadioButton();
            this.groupBox_RSS = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_URL = new System.Windows.Forms.TextBox();
            this.groupBox_TextoFijo = new System.Windows.Forms.GroupBox();
            this.textBox_Texto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_EliminarFecha = new System.Windows.Forms.Button();
            this.button_AgregarFecha = new System.Windows.Forms.Button();
            this.dataGridView_Fecha = new System.Windows.Forms.DataGridView();
            this.dateTimePicker_Hasta = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker_Desde = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_EliminarHora = new System.Windows.Forms.Button();
            this.button_AgregarHora = new System.Windows.Forms.Button();
            this.dataGridView_Hora = new System.Windows.Forms.DataGridView();
            this.maskedTextBox_Hasta = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.maskedTextBox_Desde = new System.Windows.Forms.MaskedTextBox();
            this.button_Cancelar = new System.Windows.Forms.Button();
            this.button_Aceptar = new System.Windows.Forms.Button();
            this.groupBox_RSS.SuspendLayout();
            this.groupBox_TextoFijo.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Fecha)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Hora)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton_FuenteRSS
            // 
            this.radioButton_FuenteRSS.AutoSize = true;
            this.radioButton_FuenteRSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton_FuenteRSS.Location = new System.Drawing.Point(125, 77);
            this.radioButton_FuenteRSS.Name = "radioButton_FuenteRSS";
            this.radioButton_FuenteRSS.Size = new System.Drawing.Size(102, 21);
            this.radioButton_FuenteRSS.TabIndex = 1;
            this.radioButton_FuenteRSS.TabStop = true;
            this.radioButton_FuenteRSS.Text = "Fuente RSS";
            this.radioButton_FuenteRSS.UseVisualStyleBackColor = true;
            this.radioButton_FuenteRSS.CheckedChanged += new System.EventHandler(this.radioButton_FuenteRSS_CheckedChanged);
            // 
            // radioButton_TextoFijo
            // 
            this.radioButton_TextoFijo.AutoSize = true;
            this.radioButton_TextoFijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton_TextoFijo.Location = new System.Drawing.Point(125, 100);
            this.radioButton_TextoFijo.Name = "radioButton_TextoFijo";
            this.radioButton_TextoFijo.Size = new System.Drawing.Size(87, 21);
            this.radioButton_TextoFijo.TabIndex = 2;
            this.radioButton_TextoFijo.TabStop = true;
            this.radioButton_TextoFijo.Text = "Texto Fijo";
            this.radioButton_TextoFijo.UseVisualStyleBackColor = true;
            this.radioButton_TextoFijo.CheckedChanged += new System.EventHandler(this.radioButton_TextoFijo_CheckedChanged);
            // 
            // groupBox_RSS
            // 
            this.groupBox_RSS.Controls.Add(this.label5);
            this.groupBox_RSS.Controls.Add(this.textBox_URL);
            this.groupBox_RSS.Location = new System.Drawing.Point(57, 137);
            this.groupBox_RSS.Name = "groupBox_RSS";
            this.groupBox_RSS.Size = new System.Drawing.Size(224, 158);
            this.groupBox_RSS.TabIndex = 2;
            this.groupBox_RSS.TabStop = false;
            this.groupBox_RSS.Text = "RSS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(17, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "URL";
            // 
            // textBox_URL
            // 
            this.textBox_URL.Location = new System.Drawing.Point(20, 50);
            this.textBox_URL.Multiline = true;
            this.textBox_URL.Name = "textBox_URL";
            this.textBox_URL.Size = new System.Drawing.Size(190, 70);
            this.textBox_URL.TabIndex = 3;
            // 
            // groupBox_TextoFijo
            // 
            this.groupBox_TextoFijo.Controls.Add(this.textBox_Texto);
            this.groupBox_TextoFijo.Controls.Add(this.label4);
            this.groupBox_TextoFijo.Location = new System.Drawing.Point(304, 137);
            this.groupBox_TextoFijo.Name = "groupBox_TextoFijo";
            this.groupBox_TextoFijo.Size = new System.Drawing.Size(232, 158);
            this.groupBox_TextoFijo.TabIndex = 3;
            this.groupBox_TextoFijo.TabStop = false;
            this.groupBox_TextoFijo.Text = "Texto Fijo";
            // 
            // textBox_Texto
            // 
            this.textBox_Texto.Location = new System.Drawing.Point(20, 52);
            this.textBox_Texto.Multiline = true;
            this.textBox_Texto.Name = "textBox_Texto";
            this.textBox_Texto.Size = new System.Drawing.Size(190, 70);
            this.textBox_Texto.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(17, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Texto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(45, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(125, 39);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(156, 20);
            this.textBox_Nombre.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(743, 69);
            this.label2.TabIndex = 4;
            this.label2.Text = "Banner";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(72, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 69);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(743, 359);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.textBox_Nombre);
            this.tabPage1.Controls.Add(this.groupBox_TextoFijo);
            this.tabPage1.Controls.Add(this.groupBox_RSS);
            this.tabPage1.Controls.Add(this.radioButton_TextoFijo);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.radioButton_FuenteRSS);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(735, 333);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Configuración Básica";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(735, 333);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rangos horarios";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.button_EliminarFecha);
            this.groupBox2.Controls.Add(this.button_AgregarFecha);
            this.groupBox2.Controls.Add(this.dataGridView_Fecha);
            this.groupBox2.Controls.Add(this.dateTimePicker_Hasta);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dateTimePicker_Desde);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 327);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rango de Fechas";
            // 
            // button_EliminarFecha
            // 
            this.button_EliminarFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button_EliminarFecha.Image = ((System.Drawing.Image)(resources.GetObject("button_EliminarFecha.Image")));
            this.button_EliminarFecha.Location = new System.Drawing.Point(345, 143);
            this.button_EliminarFecha.Name = "button_EliminarFecha";
            this.button_EliminarFecha.Size = new System.Drawing.Size(25, 25);
            this.button_EliminarFecha.TabIndex = 20;
            this.button_EliminarFecha.UseVisualStyleBackColor = true;
            this.button_EliminarFecha.Click += new System.EventHandler(this.button_EliminarFecha_Click);
            // 
            // button_AgregarFecha
            // 
            this.button_AgregarFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button_AgregarFecha.Image = ((System.Drawing.Image)(resources.GetObject("button_AgregarFecha.Image")));
            this.button_AgregarFecha.Location = new System.Drawing.Point(314, 143);
            this.button_AgregarFecha.Name = "button_AgregarFecha";
            this.button_AgregarFecha.Size = new System.Drawing.Size(25, 25);
            this.button_AgregarFecha.TabIndex = 19;
            this.button_AgregarFecha.UseVisualStyleBackColor = true;
            this.button_AgregarFecha.Click += new System.EventHandler(this.button_AgregarFecha_Click);
            // 
            // dataGridView_Fecha
            // 
            this.dataGridView_Fecha.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Fecha.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView_Fecha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Fecha.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_Fecha.EnableHeadersVisualStyles = false;
            this.dataGridView_Fecha.Location = new System.Drawing.Point(3, 174);
            this.dataGridView_Fecha.Name = "dataGridView_Fecha";
            this.dataGridView_Fecha.ReadOnly = true;
            this.dataGridView_Fecha.RowHeadersVisible = false;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridView_Fecha.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Fecha.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_Fecha.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Fecha.Size = new System.Drawing.Size(370, 150);
            this.dataGridView_Fecha.TabIndex = 15;
            this.dataGridView_Fecha.SelectionChanged += new System.EventHandler(this.dataGridView_Fecha_SelectionChanged);
            // 
            // dateTimePicker_Hasta
            // 
            this.dateTimePicker_Hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dateTimePicker_Hasta.Location = new System.Drawing.Point(109, 73);
            this.dateTimePicker_Hasta.Name = "dateTimePicker_Hasta";
            this.dateTimePicker_Hasta.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_Hasta.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label9.Location = new System.Drawing.Point(69, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Hasta";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label10.Location = new System.Drawing.Point(66, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Desde";
            // 
            // dateTimePicker_Desde
            // 
            this.dateTimePicker_Desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dateTimePicker_Desde.Location = new System.Drawing.Point(109, 42);
            this.dateTimePicker_Desde.Name = "dateTimePicker_Desde";
            this.dateTimePicker_Desde.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_Desde.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.button_EliminarHora);
            this.groupBox1.Controls.Add(this.button_AgregarHora);
            this.groupBox1.Controls.Add(this.dataGridView_Hora);
            this.groupBox1.Controls.Add(this.maskedTextBox_Hasta);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.maskedTextBox_Desde);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(390, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 327);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rango Horario";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button_EliminarHora
            // 
            this.button_EliminarHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button_EliminarHora.Image = ((System.Drawing.Image)(resources.GetObject("button_EliminarHora.Image")));
            this.button_EliminarHora.Location = new System.Drawing.Point(311, 143);
            this.button_EliminarHora.Name = "button_EliminarHora";
            this.button_EliminarHora.Size = new System.Drawing.Size(25, 25);
            this.button_EliminarHora.TabIndex = 22;
            this.button_EliminarHora.UseVisualStyleBackColor = true;
            this.button_EliminarHora.Click += new System.EventHandler(this.button_EliminarHora_Click);
            // 
            // button_AgregarHora
            // 
            this.button_AgregarHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button_AgregarHora.Image = ((System.Drawing.Image)(resources.GetObject("button_AgregarHora.Image")));
            this.button_AgregarHora.Location = new System.Drawing.Point(280, 143);
            this.button_AgregarHora.Name = "button_AgregarHora";
            this.button_AgregarHora.Size = new System.Drawing.Size(25, 25);
            this.button_AgregarHora.TabIndex = 21;
            this.button_AgregarHora.UseVisualStyleBackColor = true;
            this.button_AgregarHora.Click += new System.EventHandler(this.button_AgregarHora_Click);
            // 
            // dataGridView_Hora
            // 
            this.dataGridView_Hora.AllowUserToAddRows = false;
            this.dataGridView_Hora.AllowUserToDeleteRows = false;
            this.dataGridView_Hora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Hora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Hora.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_Hora.EnableHeadersVisualStyles = false;
            this.dataGridView_Hora.Location = new System.Drawing.Point(3, 174);
            this.dataGridView_Hora.Name = "dataGridView_Hora";
            this.dataGridView_Hora.ReadOnly = true;
            this.dataGridView_Hora.RowHeadersVisible = false;
            this.dataGridView_Hora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Hora.Size = new System.Drawing.Size(336, 150);
            this.dataGridView_Hora.TabIndex = 16;
            // 
            // maskedTextBox_Hasta
            // 
            this.maskedTextBox_Hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.maskedTextBox_Hasta.Location = new System.Drawing.Point(115, 73);
            this.maskedTextBox_Hasta.Mask = "00:00";
            this.maskedTextBox_Hasta.Name = "maskedTextBox_Hasta";
            this.maskedTextBox_Hasta.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_Hasta.TabIndex = 9;
            this.maskedTextBox_Hasta.Text = "0000";
            this.maskedTextBox_Hasta.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.Location = new System.Drawing.Point(75, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Hasta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(72, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Desde";
            // 
            // maskedTextBox_Desde
            // 
            this.maskedTextBox_Desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.maskedTextBox_Desde.Location = new System.Drawing.Point(115, 46);
            this.maskedTextBox_Desde.Mask = "00:00";
            this.maskedTextBox_Desde.Name = "maskedTextBox_Desde";
            this.maskedTextBox_Desde.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_Desde.TabIndex = 6;
            this.maskedTextBox_Desde.Text = "0000";
            this.maskedTextBox_Desde.ValidatingType = typeof(System.DateTime);
            // 
            // button_Cancelar
            // 
            this.button_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button_Cancelar.Location = new System.Drawing.Point(632, 447);
            this.button_Cancelar.Name = "button_Cancelar";
            this.button_Cancelar.Size = new System.Drawing.Size(93, 43);
            this.button_Cancelar.TabIndex = 9;
            this.button_Cancelar.Text = "Cancelar";
            this.button_Cancelar.UseVisualStyleBackColor = true;
            this.button_Cancelar.Click += new System.EventHandler(this.button_Cancelar_Click);
            // 
            // button_Aceptar
            // 
            this.button_Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button_Aceptar.Location = new System.Drawing.Point(533, 447);
            this.button_Aceptar.Name = "button_Aceptar";
            this.button_Aceptar.Size = new System.Drawing.Size(93, 43);
            this.button_Aceptar.TabIndex = 8;
            this.button_Aceptar.Text = "Aceptar";
            this.button_Aceptar.UseVisualStyleBackColor = true;
            this.button_Aceptar.Click += new System.EventHandler(this.button_Aceptar_Click);
            // 
            // Form_Configuración_Banner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 502);
            this.Controls.Add(this.button_Cancelar);
            this.Controls.Add(this.button_Aceptar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Name = "Form_Configuración_Banner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración -> Banner";
            this.groupBox_RSS.ResumeLayout(false);
            this.groupBox_RSS.PerformLayout();
            this.groupBox_TextoFijo.ResumeLayout(false);
            this.groupBox_TextoFijo.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Fecha)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Hora)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_FuenteRSS;
        private System.Windows.Forms.RadioButton radioButton_TextoFijo;
        private System.Windows.Forms.GroupBox groupBox_RSS;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_TextoFijo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_URL;
        private System.Windows.Forms.TextBox textBox_Texto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button_Cancelar;
        private System.Windows.Forms.Button button_Aceptar;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Desde;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Desde;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Hasta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Hasta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_EliminarFecha;
        private System.Windows.Forms.Button button_AgregarFecha;
        private System.Windows.Forms.DataGridView dataGridView_Hora;
        private System.Windows.Forms.DataGridView dataGridView_Fecha;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_EliminarHora;
        private System.Windows.Forms.Button button_AgregarHora;
    }
}