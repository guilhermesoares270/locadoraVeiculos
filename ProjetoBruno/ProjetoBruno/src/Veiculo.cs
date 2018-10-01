using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBruno.src
{
    public class Veiculo
    {
        public String modelo { get; set; }
        public Double preco { get; set; }
        public String renavam { get; set; }
        public String imageSrc { get; set; }
        public String cor { get; set; }
        public String km { get; set; }
        public String combustivel { get; set; }
        public String cambio { get; set; }
        public String portas { get; set; }

        public Veiculo() { }

        public Veiculo(String modelo, String cor, String km, String combustivel, String cambio, String portas)
        {
            this.modelo = modelo;
            this.cor = cor;
            this.km = km;
            this.combustivel = combustivel;
            this.cambio = cambio;
            this.portas = portas;
        }

        public void cadastrar()
        {

        }
    }
}
