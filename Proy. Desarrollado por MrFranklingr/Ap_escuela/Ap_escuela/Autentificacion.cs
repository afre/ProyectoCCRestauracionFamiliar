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
    public partial class Autentificacion : Form
    {
        public string valor;
        public Autentificacion()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if(UsuarioDAL.Autentificar(txtUsuario.Text,txtContraseña.Text)>0)
                {


                    if (valor == "Administrador")
                    {
                        this.Hide();
                        Form2 f = new Form2();
                        f.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Error en los datos");
                    }


                    
                }
                else
                    MessageBox.Show("Error en los datos");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea Salir", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (UsuarioDAL.Autentificar(txtUsuario.Text, txtContraseña.Text) > 0)
                {
                    this.Hide();
                    Form1 f = new Form1();
                    f.ShowDialog();
                }
                else
                    MessageBox.Show("Error en los datos");

           }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Autentificacion_Load(object sender, EventArgs e)
        {
            //Centrar el Panel
            Size desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize; //Captura el Tamaño del Monitor
            Int32 alto = (desktopSize.Height - 280) / 2;
            Int32 ancho = (desktopSize.Width - 500) / 2;
            panel1.Location = new Point(ancho, alto);
            //Fin central el Panel
            //Mostrar Fecha y Hora
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToLongTimeString();

            UsuarioDAL comb = new UsuarioDAL();
            comb.llenarItems(comboBox1);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            valor = comboBox1.SelectedItem.ToString();
        }

      


       
    }
}
