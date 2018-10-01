using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;

using ProjetoBruno.src;

namespace ProjetoBruno.Telas
{
    public partial class LoginUI : Form
    {
        //private LoginUI loginController = null;

        public LoginUI()
        {
            InitializeComponent();
            textBox1.Text = "Agamenon";
            textBox2.Text = "1234";
        }

        private void LoginUI_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            validarSenha(textBox1.Text, textBox2.Text);
            
        }

        private void validarSenha(String nome, String senha)
        {
            XmlHelper xml = new XmlHelper();
            Funcionario find_user = xml.login(textBox1.Text, textBox2.Text);
            if (find_user != null)
            {

                this.Hide();
                new Principal(find_user).Show();
            }
            else
            {
                Console.WriteLine("Não encontrado");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
