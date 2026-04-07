using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ClubDeportivo.Control; // Importa la capa de negocio


namespace ClubDeportivo
{
    // 'partial' indica que esta clase se completa con frmInscripcion.Designer.cs
    public partial class frmInscripcion : Form
    {
        public frmInscripcion()
        {
            // VITAL: SÓLO se llama (call), NO se define (define).
            InitializeComponent();

            // --- Configuración inicial de los controles ---

            // Asignar items si no están en el diseñador 
            if (cboEstado.Items.Count == 0)
            {
                cboEstado.Items.AddRange(new object[] { "ACTIVO", "INACTIVO" });
            }
            cboEstado.SelectedIndex = 0;

            // Asignar fechas por defecto
            dtpFechaDeInscripcion.Value = DateTime.Now.Date;
            dtpFechaDeNacimiento.Value = DateTime.Now.AddYears(-20).Date;
        }

        // --- MANEJADORES DE EVENTOS (Lógica de comportamiento) ---

        private void frmInscripcion_Load(object sender, EventArgs e)
        {
            // Lógica de carga, si es necesaria
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Restringe la entrada a solo números en el campo DNI
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // 1. Validación de datos obligatorios
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                MessageBox.Show("El Nombre y Número de Documento son obligatorios.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Extracción de datos del formulario (usa las variables del Designer.cs)
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string doc = txtDNI.Text.Trim();
            string tipoDocumento = cboTipoDocumento.SelectedItem.ToString(); // Usamos el ComboBox

            string estado = cboEstado.SelectedItem.ToString();
            DateTime fechaNacimiento = dtpFechaDeNacimiento.Value.Date;
            DateTime fechaInscripcion = dtpFechaDeInscripcion.Value.Date;
            bool aptoFisico = chkEntregoAptoFisico.Checked;

            // 3. Llamada a la Lógica de Negocio/Control
            try
            {
                // Asegúrate de que C_Socio esté accesible y configurado en tu proyecto
                C_Socio negocio = new C_Socio();

                string respuesta = negocio.Inscribir(
                    nombre, apellido, tipoDocumento, doc, estado,
                    fechaNacimiento, fechaInscripcion, aptoFisico
                );

                // 4. Manejo de la Respuesta
                if (respuesta.StartsWith("OK"))
                {
                    MessageBox.Show($"Inscripción exitosa. {respuesta.Split('|')[1]}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLimpiar_Click(sender, e); // Limpiar después del éxito
                }
                else
                {
                    MessageBox.Show(respuesta.Split('|')[1], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error general del sistema: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpia los campos del formulario
            txtNombre.Clear();
            txtApellido.Clear();
            txtDNI.Clear();
            cboEstado.SelectedIndex = 0;
            cboTipoDocumento.SelectedIndex = 0; // También limpiamos el tipo de documento
            dtpFechaDeNacimiento.Value = DateTime.Now.AddYears(-20).Date;
            dtpFechaDeInscripcion.Value = DateTime.Now.Date;
            chkEntregoAptoFisico.Checked = false;
            txtNombre.Focus();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            // Cierra el formulario actual
            this.Close();
        }
    }
}