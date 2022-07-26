using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FSReboot
{
    public partial class Registro_de_Prueba : Form
    {
       
        public Registro_de_Prueba()
        {
            InitializeComponent();
        }

        private void PanelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            Codigo_Auxiliar.ReleaseCapture();
            Codigo_Auxiliar.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OlvidoUsuario_ContraseñaLabel_Click(object sender, EventArgs e)
        {
            Login Usuarios_LG = new Login();
            this.Hide();
            Usuarios_LG.Show();
        }

        private void AccederButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ContraseñaTextBox.Text == ConfirmarContraseñaTextBox.Text) 
                {
                    this.usuariosTableAdapter.REGISTRAR_USUARIO(UsuarioTextBox.Text, NombresTextBox.Text, ApellidosTextBox.Text, ContraseñaTextBox.Text, CorreoTextBox.Text);
                    MessageBox.Show("El Usuario: " + UsuarioTextBox.Text + " ha sido registrado exitosamente.", "FSREBOOT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden.", "FSREBOOT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception error)
            {
                
                MessageBox.Show(error.ToString());
            }
        }
        private void LimpiarCampos() 
        {
            UsuarioTextBox.Clear();
            ContraseñaTextBox.Clear();
            ConfirmarContraseñaTextBox.Clear();
            NombresTextBox.Clear();
            ApellidosTextBox.Clear();
            CorreoTextBox.Clear();
        }

       
    }
}
