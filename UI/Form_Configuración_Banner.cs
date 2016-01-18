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
    public partial class Form_Configuración_Banner : Form
    {
        Banner banner = new Banner();

        public Form_Configuración_Banner()
        {
            InitializeComponent();
            this.CancelButton = this.button_Cancelar;
            this.radioButton_FuenteRSS.Checked = true;
            this.groupBox_TextoFijo.Enabled = false;



            try
            {
                // Initialize the DataGridView.
                var source = new BindingSource();
                source.DataSource = banner.ListaRangosFecha;

                this.dataGridView_Fecha.AutoGenerateColumns = false;
                this.dataGridView_Fecha.AutoSize = false;
                this.dataGridView_Fecha.DataSource = source;

                // Initialize and add a text box column.
                DataGridViewColumn column = new DataGridViewTextBoxColumn();
                column.DataPropertyName = "FechaInicio";
                column.Name = "Fecha de inicio";
                this.dataGridView_Fecha.Columns.Add(column);

                // Initialize and add a text box column.
                column = new DataGridViewTextBoxColumn();
                column.DataPropertyName = "FechaFin";
                column.Name = "Fecha Fin";
                this.dataGridView_Fecha.Columns.Add(column);



                this.dataGridView_Hora.AutoGenerateColumns = false;
                this.dataGridView_Hora.AutoSize = false;
                this.dataGridView_Hora.DataSource = source;

                // Initialize and add a text box column.
                column = new DataGridViewTextBoxColumn();
                column.DataPropertyName = "HoraInicio";
                column.Name = "Hora de inicio";
                this.dataGridView_Hora.Columns.Add(column);

                // Initialize and add a text box column.
                column = new DataGridViewTextBoxColumn();
                column.DataPropertyName = "HoraFin";
                column.Name = "Hora Finalización";
                this.dataGridView_Hora.Columns.Add(column);




            }
            catch (NullReferenceException)
            {
            }



        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cancelar? Se perderán los datos no guardados", "Banner", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void radioButton_FuenteRSS_CheckedChanged(object sender, EventArgs e)
        {
            this.groupBox_TextoFijo.Enabled = false;
            this.groupBox_RSS.Enabled = true;
        }

        private void radioButton_TextoFijo_CheckedChanged(object sender, EventArgs e)
        {
            this.groupBox_TextoFijo.Enabled = true;
            this.groupBox_RSS.Enabled = false;
        }

        private void button_Aceptar_Click(object sender, EventArgs e)
        {
            if (Comprobar_CamposLlenos())
            {
                banner.Nombre = this.textBox_Nombre.Text;

                if (radioButton_FuenteRSS.Checked)
                {
                    banner.InstanciaTexto = new RSS() { URL = textBox_URL.Text };
                }
                else { banner.InstanciaTexto = new TextoFijo() { Texto = textBox_Texto.Text }; }

                Fachada.Instancia.AgregarBanner(banner);
                MessageBox.Show("Los datos se han guardado correctamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("Verifique que todos los campos estén completos");

            }
        }

        /// <summary>
        /// Verifica si todos los campos están llenos
        /// </summary>
        /// <returns></returns>
        private Boolean Comprobar_CamposLlenos()
        {
            Boolean valorFinal;
            if (this.textBox_Nombre.Text == "")
            {
                valorFinal = false;
            }
            else
            {
                if (radioButton_FuenteRSS.Checked && textBox_URL.Text != "")
                {
                    valorFinal = true;
                }
                else
                {
                    if (radioButton_TextoFijo.Checked && textBox_Texto.Text != "")
                    {
                        valorFinal = true;
                    }
                    else
                    {
                        valorFinal = false;
                    }
                }
            }
            return valorFinal;

        }


        private void button_AgregarFecha_Click(object sender, EventArgs e)
        {
            Fachada.Instancia.AgregarRangoFecha(banner,this.dateTimePicker_Desde.Value, this.dateTimePicker_Hasta.Value);
            this.ActualizarListaFechas();

        }

        private void button_EliminarFecha_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaDesde = DateTime.Parse(this.dataGridView_Fecha.SelectedCells[0].Value.ToString());
                DateTime fechaHasta = DateTime.Parse(this.dataGridView_Fecha.SelectedCells[1].Value.ToString());
                RangoFecha rangoFecha = Fachada.Instancia.BuscarRangoFechaEnLista(banner, fechaDesde, fechaHasta);
                banner.ListaRangosFecha.Remove(rangoFecha);
                this.ActualizarListaFechas();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Debe seleccionar un rango de fechas");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button_AgregarHora_Click(object sender, EventArgs e)
        {
            TimeSpan tiempoDesde = TimeSpan.Parse(this.maskedTextBox_Desde.Text);
            TimeSpan tiempoHasta = TimeSpan.Parse(this.maskedTextBox_Hasta.Text);
            DateTime fechaDesde = DateTime.Parse(this.dataGridView_Fecha.SelectedCells[0].Value.ToString());
            DateTime fechaHasta = DateTime.Parse(this.dataGridView_Fecha.SelectedCells[1].Value.ToString());
            RangoFecha rangoFecha = banner.BuscarRangoFechaEnLista(fechaDesde, fechaHasta);
            Fachada.Instancia.AgregarRangoHorario(rangoFecha,
                tiempoDesde,tiempoHasta);
            this.ActualizarListaHorarios(fechaDesde,fechaHasta);
        }

        /// <summary>
        /// Actualiza la lista de Fechas
        /// </summary>
        private void ActualizarListaFechas()
        {
            try
            {
                var source = new BindingSource();
                source.DataSource = Fachada.Instancia.RangoFechas(banner);
                this.dataGridView_Fecha.DataSource = source;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No existen Fechas");
            }
        }


        /// <summary>
        /// Actualiza la lista de horarios
        /// </summary>
        private void ActualizarListaHorarios(DateTime pFechaDesde,DateTime pFechaHasta)
        {
            try
            {
                var source = new BindingSource();
                source.DataSource = Fachada.Instancia.BuscarRangoFechaEnLista(banner, pFechaDesde,pFechaHasta).ListaRangosHorario;
                this.dataGridView_Hora.DataSource = source;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No existen Horas");
            }
        }

        private void dataGridView_Fecha_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaDesde = DateTime.Parse(this.dataGridView_Fecha.SelectedCells[0].Value.ToString());
                DateTime fechaHasta = DateTime.Parse(this.dataGridView_Fecha.SelectedCells[1].Value.ToString());
                this.ActualizarListaHorarios(fechaDesde,fechaHasta);
            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }

        private void button_EliminarHora_Click(object sender, EventArgs e)
        {
            try
            {
                TimeSpan horaDesde = TimeSpan.Parse(this.dataGridView_Hora.SelectedCells[0].Value.ToString());
                TimeSpan horaHasta = TimeSpan.Parse(this.dataGridView_Hora.SelectedCells[1].Value.ToString());
                DateTime fechaDesde = DateTime.Parse(this.dataGridView_Fecha.SelectedCells[0].Value.ToString());
                DateTime fechaHasta = DateTime.Parse(this.dataGridView_Fecha.SelectedCells[1].Value.ToString());
                Fachada.Instancia.BuscarRangoFechaEnLista(banner,fechaDesde,fechaHasta).
                    ListaRangosHorario.RemoveAll(x=> x.HoraInicio==horaDesde && x.HoraFin==horaHasta);
                this.ActualizarListaHorarios(fechaDesde,fechaHasta);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Debe seleccionar un rango horario");
            }
        }
    }
    }
