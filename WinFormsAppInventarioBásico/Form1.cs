using System.Windows.Forms;

namespace WinFormsAppInventarioBásico
{
    public partial class Form1 : Form
    {
        private int n = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = textBoxProductos.Text;
            dataGridView1.Rows[n].Cells[1].Value = textBoxCantidades.Text;
            textBoxProductos.Text = " ";
            textBoxCantidades.Text = " ";



        }

        private void buttonSalida_Click(object sender, EventArgs e)
        {
            DialogResult n = MessageBox.Show("Está por salir de la App", "Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (n == DialogResult.Yes)
            {
                Close();
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (n != -1)
            {
                dataGridView1.Rows.RemoveAt(n);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;
            if (n != -1)
            {
                labelInfo.Text = (string)dataGridView1.Rows[n].Cells[1].Value;

            }
        }

        private void groupBoxRegistro_Enter(object sender, EventArgs e)
        {

        }
    }
}
