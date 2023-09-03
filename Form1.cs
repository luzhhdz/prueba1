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
                // Obtener el programa seleccionado del ComboBox
                string programaSeleccionado = cmbPrograma.SelectedItem.ToString();

                // Actualizar el mensaje en el Label Mensaje
                lblMensaje.Text = "!Felicidades!. Usted ha seleccionado: " + programaSeleccionado;
                // Mostrar los datos ingresados en los Labels correspondientes
                lblNombreEstudiante.Text = string.Format(txtNombreCompleto.Text);
                lblCarnetEstudiante.Text = string.Format(txtCarnet.Text);
                lblGrupoTeorico.Text = string.Format(txtGrupoTeorico.Text);


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
