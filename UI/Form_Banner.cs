using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Windows.Forms;

namespace UI
{
    public partial class Form_Banner : Form
    {
        public Form_Banner()
        {
            InitializeComponent();

            try
            {
                // Initialize the DataGridView.
                var source = new BindingSource();
                source.DataSource = Fachada.Instancia.ListaBanners;

                this.dataGridView_Banners.AutoGenerateColumns = false;
                this.dataGridView_Banners.AutoSize = false;
                this.dataGridView_Banners.DataSource = source;

                // Initialize and add a text box column.
                DataGridViewColumn column = new DataGridViewTextBoxColumn();
                column.DataPropertyName = "Nombre";
                column.Name = "Nombre";
                this.dataGridView_Banners.Columns.Add(column);

                // Initialize and add a text box column.
                column = new DataGridViewTextBoxColumn();
                column.DataPropertyName = "Texto";
                column.Name = "Texto";
                this.dataGridView_Banners.Columns.Add(column);

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No existen elementos");
            }



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_Agregar_Click(object sender, EventArgs e)
        {
            Form_Configuración_Banner formC = new Form_Configuración_Banner();
            formC.ShowDialog();
            this.ActualizarListaBanners();

        }

        private void button_Aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Actualiza la lista de banners
        /// </summary>
        private void ActualizarListaBanners()
        {
            var source = new BindingSource();
            source.DataSource = Fachada.Instancia.ListaBanners;
            this.dataGridView_Banners.DataSource = source;
        }

        private void button_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Banner banner = new Banner(0, this.dataGridView_Banners.SelectedCells[0].Value.ToString());
                Fachada.Instancia.ListaBanners.RemoveAll(x => x.Nombre == banner.Nombre);
                this.ActualizarListaBanners();
            }
            catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("Debe seleccionar un banner");
            }
        }
    }
}
