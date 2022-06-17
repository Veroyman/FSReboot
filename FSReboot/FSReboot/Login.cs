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
    }
}
