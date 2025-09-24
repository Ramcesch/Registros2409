using Registros.Dao;
using Registros.Modelos;
using System;
using System.Windows.Forms;

namespace Registros
{
    public partial class Form1 : Form
    {
        ProductoDao dao = new ProductoDao();
        public Form1()
        {
            InitializeComponent();
            LlenarGrid();
        }

        public void LlenarGrid()
        {
            dgvRegistros.DataSource = dao.VerCarrito();
            dgvRegistros.Refresh();
        }

        private void btnResgistrar_Click(object sender, EventArgs e)
        {
            Producto prod = new Producto();
            try
            {
                prod.Nombre = tbNombre.Text.ToUpper();
                prod.Codigo = tbCodigo.Text.ToUpper();
                prod.Precio = Double.Parse(tbPrecio.Text);
                prod.IVA = chkIVA.Checked;
            }
            catch (FormatException)
            {
                MessageBox.Show("NO se puede agregar texto en el precio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dao.Agregar(prod);
            LlenarGrid();

        }
    }
}
