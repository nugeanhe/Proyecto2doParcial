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

namespace CapaPresentacion.UI
{
    public partial class FmrGestionUsuario : Form
    {
        public FmrGestionUsuario()
        {
            InitializeComponent();
            this.Shown += FmrGestionUsuario_Shown;
            txtBuscarUsuario.Enter += txtBuscarUsuario_Enter;
            txtBuscarUsuario.Leave += txtBuscarUsuario_Leave;
        }

        //Estética de paneles
        private void RedondearPanel(Panel panel, int radius = 60)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panel.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            panel.Region = new Region(path);
        }

        private void FmrGestionUsuario_Shown(object sender, EventArgs e)
        {
            RedondearPanel(panelConten, 60);
            RedondearPanel(panelCampoUsuario, 30);
            RedondearPanel(panelCampoContraseña, 30);
            RedondearPanel(panelBuscarUsuario, 30);
            RedondearPanel(panelTabla, 60);

        }

        //Busqueda texto de sugerencia

        private void txtBuscarUsuario_Enter(object sender, EventArgs e)
        {
            if (txtBuscarUsuario.ForeColor == Color.Gray)
            {
                txtBuscarUsuario.Text = "";
                txtBuscarUsuario.ForeColor = Color.Black;
            }
        }

        private void txtBuscarUsuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarUsuario.Text))
            {
                txtBuscarUsuario.Text = "Buscar Usuario...";
                txtBuscarUsuario.ForeColor = Color.Gray;
            }
        }

        private void limpiar_controles()
        {
            txtUsuario.Text = string.Empty;
            txtContraseña.Text = string.Empty;
        }

        private bool ValidarCampos()
        {
            // Validar Usuario (cédula)
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Ingrese el número de cédula.");
                txtUsuario.Focus();
                return false;
            }

            if (!txtUsuario.Text.All(char.IsDigit))
            {
                MessageBox.Show("La cédula solo debe contener números.");
                txtUsuario.Focus();
                return false;
            }

            if (txtUsuario.Text.Length != 10)
            {
                MessageBox.Show("La cédula debe tener exactamente 10 dígitos.");
                txtUsuario.Focus();
                return false;
            }

            // Validar Contraseña
            if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("Ingrese una contraseña.");
                txtContraseña.Focus();
                return false;
            }

            if (txtContraseña.Text.Length < 6)
            {
                MessageBox.Show("La contraseña debe tener al menos 6 caracteres.");
                txtContraseña.Focus();
                return false;
            }

            return true;
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y la tecla Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }

            // Limitar a 10 dígitos
            if (char.IsDigit(e.KeyChar) && txtUsuario.Text.Length >= 10)
            {
                e.Handled = true;
            }

        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            //no permitir espacios
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
            //limitar longitud de contraseña a 16 caracteres
            if (txtContraseña.Text.Length >= 16 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; 
            }

        }
    }
}
