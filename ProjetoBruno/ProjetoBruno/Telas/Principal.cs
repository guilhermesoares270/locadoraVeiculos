using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ProjetoBruno.src;

namespace ProjetoBruno.Telas
{
    public partial class Principal : Form
    {
        private readonly Funcionario usuario = null;
        XmlHelper xml = new XmlHelper();

        public Principal(Funcionario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            populatePersonalInfo();
        }

        private void populatePersonalInfo()
        {
            Nome.Text = usuario.nome;
            Image profile = Image.FromFile(XmlHelper.parent.FullName + usuario.imagePath);
            Bitmap btm1 = resizeImage(profile, UsuarioFoto.Width, UsuarioFoto.Height);
            UsuarioFoto.Image = btm1;
            profile.Dispose();
            Nome2.Text += ": " + usuario.nome;
            Cargo.Text += ": " + usuario.cargo;
            Rua.Text += ": " + usuario.rua;
            Numero.Text += ": " + usuario.numero;
            Bairro.Text += ": " + usuario.bairro;
        }

        private void CarInfo(Veiculo veiculo)
        {
            if (veiculo != null)
            {
                Modelo.Text = "Modelo: " + veiculo.modelo;
                Cor.Text = "Cor: " + veiculo.cor;
                Km.Text = "Km: " + veiculo.km;
                Combustivel.Text = "Combustível: " + veiculo.combustivel;
                Cambio.Text = "Câmbio: " + veiculo.cambio;
                Porta.Text = "Porta: " + veiculo.portas;

                Image vImage = Image.FromFile(XmlHelper.parent.FullName + veiculo.imageSrc);
                CarFoto.Image = resizeImage(vImage, CarFoto.Width, CarFoto.Height);
                vImage.Dispose();
            }
            else
            {
                Modelo.Text = "Modelo: ";
                Cor.Text = "Cor: ";
                Km.Text = "Km: ";
                Combustivel.Text = "Combustível: ";
                Cambio.Text = "Câmbio: ";
                Porta.Text = "Porta: ";
                CarFoto.Image = null;
            }
           
        }

        private Bitmap resizeImage(Image image, int largura, int altura)
        {
            return new Bitmap(image, largura, altura);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            String busca = textBox1.Text;
            //Veiculo bVeiculo = xml.findVeiculo(busca);
            Veiculo bVeiculo = xml.genericSearch(busca);
            if (bVeiculo != null)
            {
                CarInfo(bVeiculo);
            }
            else
            {
                textBox1.Text = "Não encontrado";
                CarInfo(null);
            }
        }
    }
}
