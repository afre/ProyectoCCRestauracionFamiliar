using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tutorial4_login;


namespace login
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            
        }
      

        private void Form3_Load(object sender, EventArgs e)
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

            Modulo mod = new Modulo();
            //conexion c = new conexion();
            mod.llenarItems(comboBox1);
            
       
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {/*
            Usuarios UsuarioOb = new Usuarios();
            UsuarioOb.Usuario = this.txt1.Text;
            UsuarioOb.Contraseña = this.txt2.Text;

            if(UsuarioOb.Buscar() ==true)
            {
                MessageBox.Show(UsuarioOb.Mensaje, "Login");
            }
            else
            {
                MessageBox.Show(UsuarioOb.Mensaje, "ERROR");
            }
            /*
            if (txt1.Text.Trim() == "")
            {
                MessageBox.Show("Asegúrese de ingresar el Usuario");
                txt1.Focus();
            }
            else if (txt2.Text.Trim() == "")
            {
                MessageBox.Show("Asegúrese de ingresar la Contraseña");
                txt2.Focus();
            }
            else
            {
                MessageBox.Show("Bienvenido Sr(a): " + txt1.Text);
                this.Hide();
                Form3 fr = new Form3();
                fr.Show();
            }*/

        }

       /* private void btnmin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }*/

        /*private void btncerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea Salir","Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }*/

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Actualizar cada segundo la Hora
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }
      /*  private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(100, 92);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Size = new Size(90, 85);
        }*/

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void alphaBlendTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void alphaBlendTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

           
        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            Usuarios UsuarioOb = new Usuarios();
            Modulo ModuloOb = new Modulo();

            UsuarioOb.Usuario = this.txt1.Text;
            UsuarioOb.Contraseña = this.txt2.Text;

            if (UsuarioOb.Buscar() == true && ModuloOb.Resultado1 == true && txt2.Text.Trim() == "")
            {
                MessageBox.Show(UsuarioOb.Mensaje, "Login");
                MessageBox.Show("Bienvenido Sr(a): " + txt1.Text);
            }
            else
            {
                MessageBox.Show(UsuarioOb.Mensaje, "ERROR");
            }


            /*
            if (txt1.Text.Trim() == "")
            {
                MessageBox.Show("Asegúrese de ingresar el Usuario");
                txt1.Focus();
            }
            else if (txt2.Text.Trim() == "")
            {
                MessageBox.Show("Asegúrese de ingresar la Contraseña");
                txt2.Focus();
            }
            else
            {
                MessageBox.Show("Bienvenido Sr(a): " + txt1.Text);
                this.Hide();
                Form3 fr = new Form3();
                fr.Show();
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea Salir", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }


        
    }
}
