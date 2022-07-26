using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FSReboot
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void AccederButton_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath AccederButtonDesign = new GraphicsPath();
            Rectangle Rectangulo = AccederButton.ClientRectangle;
            Rectangulo.Inflate(0, 25);
            AccederButtonDesign.AddEllipse(Rectangulo);
            AccederButton.Region = new Region(AccederButtonDesign);
        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PanelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            Codigo_Auxiliar.ReleaseCapture();
            Codigo_Auxiliar.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Registro_de_Prueba Usuarios_RP = new Registro_de_Prueba();
            this.Hide();
            Usuarios_RP.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'fSREBOOTDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.CargarRecuerdame(this.fSREBOOTDataSet.Usuarios);
            }
            catch (Exception error)
            {
                
              // MessageBox.Show(error.ToString());
            }

        }

        private void AccederButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt16(this.usuariosTableAdapter.INICIAR_SESION(UsuarioTextBox.Text, ContraseñaTextBox.Text)) == 1)
                {
                    this.usuariosTableAdapter.GuardarRecuerdame(Convert.ToByte(RecuerdameCheckBox.Checked), UsuarioTextBox.Text);
                    Formularios_de_Usuarios.Loggeado Usuarios_Loggeado = new Formularios_de_Usuarios.Loggeado();
                    this.Hide();
                    Usuarios_Loggeado.Show();
                }
                else
                {
                    MessageBox.Show("Usuario y/o Clave invalido.","FSREBOOT",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
                
            }
            catch (Exception error)
            {
                
                //MessageBox.Show(error.ToString());
            }
        }
    }
}
