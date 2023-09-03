using System;

using System.Windows.Forms;

namespace ControlVersion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            {
                // Validar que los campos no estén vacíos
                if (string.IsNullOrWhiteSpace(txtNombreCompleto.Text) ||
                    string.IsNullOrWhiteSpace(txtCarnet.Text) ||
                    string.IsNullOrWhiteSpace(txtGrupoTeorico.Text) ||
                    cmbPrograma.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, complete todos los campos antes de continuar.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Salir del evento si hay campos vacíos
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
