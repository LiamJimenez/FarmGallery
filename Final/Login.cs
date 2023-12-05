using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Final
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            Form1 form2 = new Form1();


            this.Hide();


            form2.Show();



        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            Registro form2 = new Registro();


            this.Hide();


            form2.Show();
        }
    }
}
