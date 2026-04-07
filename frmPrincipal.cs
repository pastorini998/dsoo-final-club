using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClubDeportivo
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            this.Text = "Gestión del Club Deportivo";
            this.StartPosition = FormStartPosition.CenterScreen;

            // Cargar los componentes dinámicos
            CargarComponentesAdministrador();
        }

        private void CargarComponentesAdministrador()
        {
            // 1. Etiqueta de Usuario
            Label lblUsuario = new Label();
            lblUsuario.Text = "Usuario: Administrador";
            lblUsuario.Font = new Font("Arial", 12, FontStyle.Bold);
            lblUsuario.Location = new Point(20, 20);
            lblUsuario.AutoSize = true;
            this.Controls.Add(lblUsuario);

            // Posición inicial para los botones
            int xButton = 50;
            int yButton = 80;
            int buttonHeight = 40;
            int buttonWidth = 200;
            int spacing = 60;

            // 2. Botón Inscribir Socio
            Button btnInscribir = CrearBoton("Inscribir Socio", new Point(xButton, yButton), buttonWidth, buttonHeight);
            btnInscribir.Click += new EventHandler(btnInscribir_Click); // Asigna el manejador
            this.Controls.Add(btnInscribir);

            // 3. Botón Pagar Cuota
            yButton += spacing;
            Button btnPagar = CrearBoton("Pagar Cuota", new Point(xButton, yButton), buttonWidth, buttonHeight);
            btnPagar.Click += new EventHandler(btnPagar_Click); // Asigna el manejador
            this.Controls.Add(btnPagar);

            // 4. Botón Emitir Carnet
            yButton += spacing;
            Button btnEmitir = CrearBoton("Emitir Carnet", new Point(xButton, yButton), buttonWidth, buttonHeight);
            btnEmitir.Click += new EventHandler(btnEmitir_Click);
            this.Controls.Add(btnEmitir);

            // 5. Botón Cuotas Vencidas
            yButton += spacing;
            Button btnVencidas = CrearBoton("Cuotas Vencidas", new Point(xButton, yButton), buttonWidth, buttonHeight);
            btnVencidas.Click += new EventHandler(btnVencidas_Click);
            btnVencidas.BackColor = Color.LightSalmon;
            this.Controls.Add(btnVencidas);

            // 6. Botón Salir
            yButton += spacing * 2;
            Button btnSalir = CrearBoton("Salir", new Point(xButton, yButton), buttonWidth, buttonHeight);
            btnSalir.Click += new EventHandler(btnSalir_Click);
            btnSalir.BackColor = Color.LightCoral;
            this.Controls.Add(btnSalir);
        }

        private Button CrearBoton(string texto, Point ubicacion, int ancho, int alto)
        {
            Button boton = new Button();
            boton.Text = texto;
            boton.Location = ubicacion;
            boton.Size = new Size(ancho, alto);
            boton.Font = new Font("Arial", 10, FontStyle.Regular);
            boton.BackColor = Color.LightBlue;
            return boton;
        }

        // --- MANEJADORES DE EVENTOS (Ahora unificados y completos) ---

        // 1. Manejador UNIFICADO para Inscribir Socio (Contiene la lógica de abrir frmInscripcion)
        private void btnInscribir_Click(object sender, EventArgs e)
        {
            try
            {
                // Aquí usamos el nuevo formulario frmInscripcion
                frmInscripcion inscripcionForm = new frmInscripcion();
                inscripcionForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar abrir el formulario de inscripción: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 2. Manejador FALTANTE, ahora agregado para que la asignación funcione
        private void btnPagar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abrir formulario para Registrar Pago de Cuota.");
        }


        private void btnEmitir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abrir funcionalidad para Emitir Carnet.");
        }

        private void btnVencidas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abrir formulario de Reporte de Cuotas Vencidas.");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
