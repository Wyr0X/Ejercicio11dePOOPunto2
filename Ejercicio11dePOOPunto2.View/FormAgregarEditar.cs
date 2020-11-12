using Ejercicio11dePOOPunto2.Business;
using Ejercicio11dePOOPunto2.Model;
using System;
using System.Windows.Forms;

namespace Ejercicio11dePOOPunto2.View
{
    public partial class FormAgregarEditar : Form
    {
        public Circunferencia CircunferenciaAE { get; set; }
        public ListaDeCircunferencias Lista { get; set; }

        public FormAgregarEditar(ListaDeCircunferencias listaDeCircunferencias)
        {
            InitializeComponent();

            Lista = listaDeCircunferencias;
        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (CircunferenciaAE == null)
                {
                    CircunferenciaAE = new Circunferencia
                    {
                        Centro = new Punto()
                        {
                            X = (int)NumericX.Value,
                            Y = (int)NumericY.Value,
                        },
                        Radio = (int)NumericRadio.Value,
                        Borde = (Borde)ComboBoxBorde.SelectedIndex,
                        Relleno = ComboBoxRelleno.SelectedItem.ToString()
                    };

                    if (Lista.Existe(CircunferenciaAE))
                    {
                        ShowError("La circunferencia ya existe.");
                        return;
                    }
                } else
                {
                    CircunferenciaAE.Centro = new Punto()
                    {
                        X = (int)NumericX.Value,
                        Y = (int)NumericY.Value,
                    };
                    CircunferenciaAE.Radio = (int)NumericRadio.Value;
                    CircunferenciaAE.Borde = (Borde)ComboBoxBorde.SelectedIndex;
                    CircunferenciaAE.Relleno = ComboBoxRelleno.SelectedItem.ToString();
                }

                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            if (NumericRadio.Value <= 0)
            {
                ShowError("El radio debe ser positivo.");
                return false;
            }

            if (ComboBoxBorde.SelectedIndex < 0)
            {
                ShowError("Debe seleccionar un tipo de borde.");
                return false;
            }

            if (ComboBoxRelleno.SelectedIndex < 0)
            {
                ShowError("Debe seleccionar un tipo de relleno.");
                return false;
            }

            return true;
        }

        private void ShowError(string error_message)
        {
            MessageBox.Show(this, error_message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FormAgregarEditar_Load(object sender, EventArgs e)
        {
            ComboBoxBorde.Items.AddRange(Enum.GetNames(typeof(Borde)));

            ComboBoxRelleno.Items.Add("Sin relleno");
            ComboBoxRelleno.Items.Add("Sólido");
            ComboBoxRelleno.Items.Add("Degradado");
            ComboBoxRelleno.Items.Add("Textura");
            ComboBoxRelleno.Items.Add("No filtrar");

            if (CircunferenciaAE != null)
            {
                NumericX.Value = CircunferenciaAE.Centro.X;
                NumericY.Value = CircunferenciaAE.Centro.Y;
                NumericRadio.Value = CircunferenciaAE.Radio;
                ComboBoxBorde.SelectedIndex = (int)CircunferenciaAE.Borde;
                ComboBoxRelleno.SelectedItem = CircunferenciaAE.Relleno;
            }
        }
    }
}
