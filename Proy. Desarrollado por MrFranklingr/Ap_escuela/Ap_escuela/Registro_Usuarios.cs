using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ap_escuela
{
    public partial class Registro_Usuarios : Form
    {
        public Registro_Usuarios()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text == txtContraseña.Text)
            {
                if (UsuarioDAL.CrearCuentas(textBox1.Text, txtUsuario.Text, txtContraseña.Text, textBox2.Text) > 0)
                {
                    MessageBox.Show("Cuenta Creada con exito");
                }
                else
                    MessageBox.Show("No se pudo crear la cuenta");
            
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Registro_Usuarios_Load(object sender, EventArgs e)
        {
            UsuarioDAL c = new UsuarioDAL();
            c.autoCompletar(textBox1);  

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

       

        

        
    }
}
