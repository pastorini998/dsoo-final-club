using ClubDeportivo.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
      
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
          
            txtPassLogin.UseSystemPasswordChar = true;
        }

        private void btnIngresarLogin_Click(object sender, EventArgs e)
        {
            DataTable tablaLogin = new DataTable();
            
            Usuarios dato = new Datos.Usuarios();
            tablaLogin = dato.Log_Usu(txtUsuarioLogin.Text, txtPassLogin.Text);

            if (tablaLogin.Rows.Count > 0)
            {
                this.Hide();
                frmPrincipal frmPrincipal = new frmPrincipal();
                frmPrincipal.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario y/o password incorrecto");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

      
    }
}