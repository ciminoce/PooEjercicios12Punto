using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PooEjercicios12Punto.Entidades;

namespace PooEjercicios12Punto.Windows
{
    public partial class FrmPuntosEdit : Form
    {
        public FrmPuntosEdit()
        {
            InitializeComponent();
        }

        private Punto punto;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CargarDatosEnComboColores(ref ColoresComboBox);
            if (punto!=null)
            {
                //Editar
                XTextBox.Text = punto.X.ToString();
                YTextBox.Text = punto.Y.ToString();
                ColoresComboBox.SelectedItem = punto.ColorDisponible;
                TrazoFinoCheckBox.Checked = punto.TrazoFino;
            }
        }

        private void CargarDatosEnComboColores(ref ComboBox combo)
        {
            combo.DataSource = Enum.GetValues(typeof(ColorDisponible));
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (punto==null)
                {
                    punto = new Punto();
                }

                punto.X = int.Parse(XTextBox.Text);
                punto.Y = int.Parse(YTextBox.Text);
                punto.ColorDisponible =(ColorDisponible) ColoresComboBox.SelectedItem;
                punto.TrazoFino = TrazoFinoCheckBox.Checked;

                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool esValido = true;
            errorProvider1.Clear();
            if (!int.TryParse(XTextBox.Text, out int x))
            {
                esValido = false;
                errorProvider1.SetError(XTextBox,"Coordenada X mal ingresada");
            }
            if (!int.TryParse(YTextBox.Text, out int y))
            {
                esValido = false;
                errorProvider1.SetError(XTextBox, "Coordenada Y mal ingresada");
            }

            return esValido;
        }

        public Punto GetPunto()
        {
            return punto;
        }

        public void SetPunto(Punto punto)
        {
            this.punto = punto;
        }
    }
}
