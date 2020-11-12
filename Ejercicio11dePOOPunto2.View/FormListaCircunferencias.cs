using Ejercicio11dePOOPunto2.Business;
using Ejercicio11dePOOPunto2.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ejercicio11dePOOPunto2.View
{
    public partial class FormListaCircunferencias : Form
    {
        private readonly ListaDeCircunferencias listaDeCircunferencias = new ListaDeCircunferencias();
        private List<Circunferencia> listaActual = new List<Circunferencia>();

        public FormListaCircunferencias()
        {
            InitializeComponent();

            // Cargo desde el archivo
            listaDeCircunferencias.Leer();
        }

        private void BotonNueva_Click(object sender, EventArgs e)
        {
            var Frm = new FormAgregarEditar(listaDeCircunferencias)
            {
                Text = "Agregar circunferencia"
            };
            var Result = Frm.ShowDialog();

            if (Result == DialogResult.OK)
            {
                listaDeCircunferencias.Agregar(Frm.CircunferenciaAE);
                listaDeCircunferencias.Guardar();
                MostrarListaEnGridView();
            }
        }

        private void MostrarListaEnGridView()
        {
            dataGridView.Rows.Clear();

            foreach (Circunferencia circunferencia in listaActual)
            {
                var row = CrearFila(circunferencia);
                dataGridView.Rows.Add(row);
            }
        }

        private DataGridViewRow CrearFila(Circunferencia circunferencia)
        {
            var row = new DataGridViewRow();
            row.CreateCells(dataGridView);

            row.Cells[0].Value = $"({circunferencia.Centro.X}, {circunferencia.Centro.Y})";
            row.Cells[1].Value = circunferencia.Radio;
            row.Cells[2].Value = circunferencia.Borde;
            row.Cells[3].Value = circunferencia.Relleno;
            row.Cells[4].Value = circunferencia.GetPerimetro();
            row.Cells[5].Value = circunferencia.GetSuperficie();
            row.Tag = circunferencia;

            return row;
        }

        private void BotonRestaurar_Click(object sender, EventArgs e)
        {
            listaActual = listaDeCircunferencias.GetLista();
            MostrarListaEnGridView();
            BotonRestaurar.Enabled = false;
        }

        private void BotonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0) return;

            DataGridViewRow row = dataGridView.SelectedRows[0];
            int row_index = row.Index;

            var Frm = new FormAgregarEditar(listaDeCircunferencias)
            {
                Text = "Editar circunferencia",
                CircunferenciaAE = (Circunferencia)row.Tag
            };
            var Result = Frm.ShowDialog();

            if (Result == DialogResult.OK)
            {
                listaDeCircunferencias.Guardar();
                MostrarListaEnGridView();

                // Seleccionamos la que acaba de editar
                dataGridView.CurrentCell = dataGridView.Rows[row_index].Cells[0];
                dataGridView.ClearSelection();
                dataGridView.Rows[row_index].Selected = true;
            }
        }

        private void BotonBorrar_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0) return;

            DataGridViewRow row = dataGridView.SelectedRows[0];
            Circunferencia circunferencia = (Circunferencia)row.Tag;
            DialogResult dr = MessageBox.Show($"¿Borrar circunferencia con centro {row.Cells[0].Value} y radio {circunferencia.Radio}?",
                "Cofirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dr == DialogResult.No) return;

            listaDeCircunferencias.Eliminar(circunferencia);
            listaDeCircunferencias.Guardar();
            MostrarListaEnGridView();
        }

        private void OrdenarRadioAsc_Click(object sender, EventArgs e)
        {
            listaActual = listaDeCircunferencias.OrdenarPorRadio(false);
            BotonRestaurar.Enabled = true;
            MostrarListaEnGridView();
        }

        private void OrdenarRadioDesc_Click(object sender, EventArgs e)
        {
            listaActual = listaDeCircunferencias.OrdenarPorRadio(true);
            BotonRestaurar.Enabled = true;
            MostrarListaEnGridView();
        }

        private void OrdenarCentroCerca_Click(object sender, EventArgs e)
        {
            listaActual = listaDeCircunferencias.OrdenarPorCentro(false);
            BotonRestaurar.Enabled = true;
            MostrarListaEnGridView();
        }

        private void OrdenarOrigenLejos_Click(object sender, EventArgs e)
        {
            listaActual = listaDeCircunferencias.OrdenarPorCentro(true);
            BotonRestaurar.Enabled = true;
            MostrarListaEnGridView();
        }

        private void ComboBoxBorde_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxBorde.SelectedItem.ToString() == "No filtrar") // No filtrar
            {
                listaActual = listaDeCircunferencias.GetLista();
                MostrarListaEnGridView();
                BotonRestaurar.Enabled = false;
            }
            else
            {
                listaActual = listaDeCircunferencias.FiltrarPorBorde((Borde)Enum.Parse(typeof(Borde), ComboBoxBorde.SelectedItem.ToString()));
                BotonRestaurar.Enabled = true;
                MostrarListaEnGridView();
            }
        }

        private void ComboBoxRelleno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxRelleno.SelectedItem.ToString() == "No filtrar") // No filtrar
            {
                listaActual = listaDeCircunferencias.GetLista();
                MostrarListaEnGridView();
                BotonRestaurar.Enabled = false;
            }
            else
            {
                listaActual = listaDeCircunferencias.FiltrarPorRelleno(ComboBoxRelleno.SelectedItem.ToString());
                BotonRestaurar.Enabled = true;
                MostrarListaEnGridView();
            }
        }

        private void FormListaCircunferencias_Load(object sender, EventArgs e)
        {
            ComboBoxBorde.Items.AddRange(Enum.GetNames(typeof(Borde)));
            ComboBoxBorde.Items.Add("No filtrar");
            ComboBoxBorde.SelectedIndex = ComboBoxBorde.Items.Count - 1;

            ComboBoxRelleno.Items.Add("Sin relleno");
            ComboBoxRelleno.Items.Add("Sólido");
            ComboBoxRelleno.Items.Add("Degradado");
            ComboBoxRelleno.Items.Add("Textura");
            ComboBoxRelleno.Items.Add("No filtrar");
            ComboBoxRelleno.SelectedIndex = ComboBoxRelleno.Items.Count - 1;

            listaActual = listaDeCircunferencias.GetLista();
            MostrarListaEnGridView();
        }
    }
}
