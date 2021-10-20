using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PooEjercicios12Punto.Datos;
using PooEjercicios12Punto.Entidades;

namespace PooEjercicios12Punto.Windows
{
    public partial class FrmListaDePuntos : Form
    {
        public FrmListaDePuntos()
        {
            InitializeComponent();
        }

        private List<Punto> lista;
        private RepositorioDePuntos repositorio;

        private void NuevoToolStripButton_Click(object sender, EventArgs e)
        {
            FrmPuntosEdit frm = new FrmPuntosEdit() {Text = "Nuevo Punto"};
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.Cancel)
            {
                return;
            }

            Punto punto = frm.GetPunto();
            if (repositorio.Existe(punto))
            {
                MessageBox.Show("Punto existente!!!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            repositorio.Agregar(punto);
            DataGridViewRow r = ConstruirFila();
            SetearFila(r, punto);
            AgregarFila(r);
        }

        private void AgregarFila(DataGridViewRow r)
        {
            DatosDataGridView.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Punto punto)
        {
            r.Cells[colX.Index].Value = punto.X;
            r.Cells[colY.Index].Value = punto.Y;
            r.Cells[colTrazo.Index].Value = punto.TrazoFino?Trazo.Fino:Trazo.Grueso;
            r.Cells[colTrazo2.Index].Value = punto.TrazoFino;
            r.Cells[colColor.Index].Value = punto.ColorDisponible;
            r.Cells[colCuadrante.Index].Value = punto.GetCuadrante();

            r.Tag = punto;
        }

        private DataGridViewRow ConstruirFila()
        {
            var r = new DataGridViewRow();
            r.CreateCells(DatosDataGridView);
            return r;
        }

        private void SalirToolStripButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmListaDePuntos_Load(object sender, EventArgs e)
        {
            repositorio = new RepositorioDePuntos();
            lista = repositorio.GetLista();
            MostrarDatosEnGrilla();
            ActualizarCantidadRegistros(repositorio.GetCantidad());
        }

        private void ActualizarCantidadRegistros(int cantidad)
        {
            CantidadRegistrosLabel.Text = cantidad.ToString();
        }

        private void MostrarDatosEnGrilla()
        {
            DatosDataGridView.Rows.Clear();
            foreach (var punto in lista)
            {
                var r = ConstruirFila();
                SetearFila(r,punto);
                AgregarFila(r);
            }
        }

        private void BorrarToolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count==0)
            {
                return;
            }

            var r = DatosDataGridView.SelectedRows[0];
            Punto punto = (Punto) r.Tag;
            DialogResult dr = MessageBox.Show("¿Desea dar de baja el registro seleccionado?", "Confirmar Baja",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr==DialogResult.No)
            {
                return;
            }
            repositorio.Borrar(punto);
            DatosDataGridView.Rows.Remove(r);
            MessageBox.Show("Registro Borrado!!!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EditarToolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            var r = DatosDataGridView.SelectedRows[0];
            var punto = (Punto)r.Tag;
            var puntoCopia = (Punto)punto.Clone();
            FrmPuntosEdit frm = new FrmPuntosEdit();
            frm.SetPunto(puntoCopia);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            puntoCopia = frm.GetPunto();
            if (repositorio.Existe(puntoCopia))
            {
                MessageBox.Show("Punto existente!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            repositorio.Editar(punto, puntoCopia);
            SetearFila(r, puntoCopia);
            MessageBox.Show("Registro modificado");
        }

        private void ascendentePorXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = repositorio.GetListaOrdenadaPorXAsc();
            MostrarDatosEnGrilla();
        }

        private void descendentePorXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = repositorio.GetListaOrdenadaPorXDesc();
            MostrarDatosEnGrilla();

        }

        private void ascedentePorYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = repositorio.GetListaOrdenadaPorYAsc();
            MostrarDatosEnGrilla();

        }

        private void descendentePorYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = repositorio.GetListaOrdenadaPorYDesc();
            MostrarDatosEnGrilla();

        }
    }
}
