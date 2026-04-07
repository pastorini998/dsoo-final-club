using System.Drawing;
using System.Windows.Forms;

namespace ClubDeportivo
{
    // La palabra 'partial' vincula esta definición con la de frmInscripcion.cs
    partial class frmInscripcion : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            // --- 1. DECLARACIÓN DE INSTANCIAS ---
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.cboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.dtpFechaDeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.chkEntregoAptoFisico = new System.Windows.Forms.CheckBox();
            this.lblFechaInscripcion = new System.Windows.Forms.Label();
            this.dtpFechaDeInscripcion = new System.Windows.Forms.DateTimePicker();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();

            // --- 2. CONFIGURACIÓN DEL FORMULARIO Y CONTROLES (COMPLETO) ---
            this.SuspendLayout();

            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(120, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(210, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Registro de Nuevo Socio";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(30, 70);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 15);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(180, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(220, 23);
            this.txtNombre.TabIndex = 2;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(30, 100);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(54, 15);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(180, 97);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(220, 23);
            this.txtApellido.TabIndex = 4;
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Location = new System.Drawing.Point(30, 130);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(102, 15);
            this.lblTipoDocumento.TabIndex = 5;
            this.lblTipoDocumento.Text = "Tipo Documento:";
            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDocumento.FormattingEnabled = true;
            this.cboTipoDocumento.Items.AddRange(new object[] { "DNI", "CUIL", "Pasaporte" });
            this.cboTipoDocumento.SelectedIndex = 0;
            this.cboTipoDocumento.Location = new System.Drawing.Point(180, 127);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.Size = new System.Drawing.Size(220, 23);
            this.cboTipoDocumento.TabIndex = 6;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(30, 160);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(123, 15);
            this.lblDNI.TabIndex = 7;
            this.lblDNI.Text = "Número Documento:";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(180, 157);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(220, 23);
            this.txtDNI.TabIndex = 8;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(30, 190);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(122, 15);
            this.lblFechaNacimiento.TabIndex = 9;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // dtpFechaDeNacimiento
            // 
            this.dtpFechaDeNacimiento.Location = new System.Drawing.Point(180, 187);
            this.dtpFechaDeNacimiento.Name = "dtpFechaDeNacimiento";
            this.dtpFechaDeNacimiento.Size = new System.Drawing.Size(220, 23);
            this.dtpFechaDeNacimiento.TabIndex = 10;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(30, 220);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(45, 15);
            this.lblEstado.TabIndex = 11;
            this.lblEstado.Text = "Estado:";
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(180, 217);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(220, 23);
            this.cboEstado.TabIndex = 12;
            // 
            // lblFechaInscripcion
            // 
            this.lblFechaInscripcion.AutoSize = true;
            this.lblFechaInscripcion.Location = new System.Drawing.Point(30, 250);
            this.lblFechaInscripcion.Name = "lblFechaInscripcion";
            this.lblFechaInscripcion.Size = new System.Drawing.Size(117, 15);
            this.lblFechaInscripcion.TabIndex = 13;
            this.lblFechaInscripcion.Text = "Fecha de Inscripción:";
            // 
            // dtpFechaDeInscripcion
            // 
            this.dtpFechaDeInscripcion.Enabled = false; // Suele ser de solo lectura para la fecha actual
            this.dtpFechaDeInscripcion.Location = new System.Drawing.Point(180, 247);
            this.dtpFechaDeInscripcion.Name = "dtpFechaDeInscripcion";
            this.dtpFechaDeInscripcion.Size = new System.Drawing.Size(220, 23);
            this.dtpFechaDeInscripcion.TabIndex = 14;
            // 
            // chkEntregoAptoFisico
            // 
            this.chkEntregoAptoFisico.AutoSize = true;
            this.chkEntregoAptoFisico.Location = new System.Drawing.Point(30, 280);
            this.chkEntregoAptoFisico.Name = "chkEntregoAptoFisico";
            this.chkEntregoAptoFisico.Size = new System.Drawing.Size(130, 19);
            this.chkEntregoAptoFisico.TabIndex = 15;
            this.chkEntregoAptoFisico.Text = "¿Entregó Apto Físico?";
            this.chkEntregoAptoFisico.UseVisualStyleBackColor = true;

            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(30, 330);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(120, 30);
            this.btnAceptar.TabIndex = 16;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(165, 330);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(120, 30);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(300, 330);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(120, 30);
            this.btnVolver.TabIndex = 18;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;

            // 
            // frmInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 420);
            this.Text = "Inscripción de Socios";

            // --- ESTO ES LO CRÍTICO: Agregar todos los controles al formulario (Controls.Add) ---
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblTipoDocumento);
            this.Controls.Add(this.cboTipoDocumento);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.dtpFechaDeNacimiento);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.lblFechaInscripcion);
            this.Controls.Add(this.dtpFechaDeInscripcion);
            this.Controls.Add(this.chkEntregoAptoFisico);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnVolver);

            // --- 3. CONEXIÓN DE EVENTOS ---
            this.Load += new System.EventHandler(this.frmInscripcion_Load);
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        // --- 4. DECLARACIÓN DE VARIABLES (VITAL PARA EL ARCHIVO DE LÓGICA) ---
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombre;
        internal System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        internal System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblTipoDocumento;
        internal System.Windows.Forms.ComboBox cboTipoDocumento;
        private System.Windows.Forms.Label lblDNI;
        internal System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblFechaNacimiento;
        internal System.Windows.Forms.DateTimePicker dtpFechaDeNacimiento;
        private System.Windows.Forms.Label lblEstado;
        internal System.Windows.Forms.ComboBox cboEstado;
        internal System.Windows.Forms.CheckBox chkEntregoAptoFisico;
        private System.Windows.Forms.Label lblFechaInscripcion;
        internal System.Windows.Forms.DateTimePicker dtpFechaDeInscripcion;
        internal System.Windows.Forms.Button btnAceptar;
        internal System.Windows.Forms.Button btnLimpiar;
        internal System.Windows.Forms.Button btnVolver;
    }
}
