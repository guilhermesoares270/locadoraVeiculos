using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBruno.src
{
    public class Funcionario
    {
        public String nome { get; set; }
        public String imagePath { get; set; }
        public String senha{ get; set;}
        public String cargo { get; set; }
        public String rua { get; set; }
        public String numero { get; set; }
        public String bairro { get; set; }

        public Funcionario() { }

        public Funcionario(String nome, String imagePath, String senha, String cargo, String rua, String numero, String bairro)
        {
            this.nome = nome;
            this.imagePath = @imagePath;
            this.senha = senha;
            this.cargo = cargo;
            this.rua = rua;
            this.numero = numero;
            this.bairro = bairro;
        }

        public void consultar()
        {

        }

        public void alterar()
        {
             
        }

        public void excluir()
        {

        }

        public void getRelatorio()
        {

        }

    }
}
