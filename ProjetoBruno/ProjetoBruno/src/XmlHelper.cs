using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace ProjetoBruno.src
{
    public class XmlHelper
    {
        public static DirectoryInfo parent = Directory.GetParent(Directory.GetCurrentDirectory()).Parent;

        //private Usuario usuario = new Usuario();

        private enum Campos{
            modelo,
            imagem,
            renavam,
            preco,
            cor,
            km,
            combustivel,
            cambio,
            porta
        }

        private String camposToString(Campos cmp)
        {
            String campo = null;
            switch (cmp)
            {
                case Campos.modelo:
                    campo = "modelo";
                    break;
                case Campos.renavam:
                    campo = "renavam";
                    break;
                default:
                    //Do nothing
                    break;
            }
            return campo;
        }

        public Veiculo genericSearch(String entrada)
        {
            //String campo = camposToString(cmp);

            Veiculo veiculo = new Veiculo();
            bool found = false;

            try
            {
                XmlDocument doc = new XmlDocument();
                Console.WriteLine("Path: " + parent.FullName + @"\Veiculos.xml");
                doc.Load(parent.FullName + @"\src\Veiculos.xml");

                //loop pelos nodes encontrados
                foreach (XmlNode node in doc.DocumentElement.ChildNodes)
                {
                    if (found)
                    {
                        break;
                    }
                    String nodeName = node.Name;
                    Console.WriteLine("\nComeçando Node: {0}", nodeName);

                    foreach (XmlElement child in node)
                    {
                        string childNome = child.Name;
                        string text = child.InnerText;
                        Console.WriteLine("Nome Atual:" + text);

                        if (String.Compare(childNome.ToLower(), "renavam") == 0)
                        {
                            if (String.Compare(text.ToLower(), entrada.ToLower()) == 0)
                            {
                                Console.WriteLine("Nome {0} encontrado", entrada);
                                found = true;
                            }
                        }
                        else if (String.Compare(childNome.ToLower(), "modelo") == 0)
                        {
                            if (String.Compare(text.ToLower(), entrada.ToLower()) == 0)
                            {
                                Console.WriteLine("Nome {0} encontrado", entrada);
                                found = true;
                            }
                        }

                        //if (found)
                        //{
                        switch (childNome)
                        {
                            case "modelo":
                                veiculo.modelo = text;
                                break;
                            case "imagem":
                                veiculo.imageSrc = @text;
                                break;
                            case "renavam":
                                veiculo.renavam = text;
                                break;
                            case "preco":
                                veiculo.preco = Double.Parse(text);
                                break;
                            case "cor":
                                veiculo.cor = text;
                                break;
                            case "km":
                                veiculo.km = text;
                                break;
                            case "combustivel":
                                veiculo.combustivel = text;
                                break;
                            case "cambio":
                                veiculo.cambio = text;
                                break;
                            case "portas":
                                veiculo.portas = text;
                                break;
                            default:
                                Console.WriteLine("Não encontado");
                                break;
                        }
                        //}
                    }
                }
                Console.WriteLine(veiculo.portas);
            }
            catch (Exception ex)
            {
                if (ex is FileNotFoundException || ex is DirectoryNotFoundException)
                {
                    Console.WriteLine("File/Directory not found", ex.Message);
                }
            }

            if (!found)
            {
                return null;
            }
            else
            {
                return veiculo;
            }
        }
        
        public Veiculo findVeiculo(String modelo)
        {
            Veiculo veiculo = new Veiculo();
            bool found = false;
            /*if (parent != null)
            {
                var directoryInfo = parent.Parent;
                string startDirectory = null;
                if (directoryInfo != null)
                {
                    startDirectory = directoryInfo.FullName;
                }
                if (startDirectory != null)
                { 
                Do whatever you want "startDirectory" variable
        }
            }*/
            try
            {
                XmlDocument doc = new XmlDocument();
                Console.WriteLine("Path: " + parent.FullName + @"\Veiculos.xml");
                doc.Load(parent.FullName + @"\src\Veiculos.xml");

                //loop pelos nodes encontrados
                foreach (XmlNode node in doc.DocumentElement.ChildNodes)
                {
                    if (found)
                    {
                        break;
                    }
                    String nodeName = node.Name;
                    Console.WriteLine("\nComeçando Node: {0}", nodeName);

                    foreach (XmlElement child in node)
                    {
                        string childNome = child.Name;
                        string text = child.InnerText;
                        Console.WriteLine("Nome Atual:" + text);
                        if (String.Compare(text.ToLower(), modelo.ToLower()) == 0)
                        {
                            Console.WriteLine("Nome {0} encontrado", modelo);
                            found = true;
                        }
                        //if (found)
                        //{
                            switch (childNome)
                            {
                                case "modelo":
                                    veiculo.modelo = text;
                                    break;
                                case "imagem":
                                    veiculo.imageSrc = @text;
                                    break;
                                case "renavam":
                                    veiculo.renavam = text;
                                    break;
                                case "preco":
                                    veiculo.preco = Double.Parse(text);
                                    break;
                                case "cor":
                                    veiculo.cor = text;
                                    break;
                                case "km":
                                    veiculo.km = text;
                                    break;
                                case "combustivel":
                                    veiculo.combustivel = text;
                                    break;
                                case "cambio":
                                    veiculo.cambio = text;
                                    break;
                                case "portas":
                                    veiculo.portas = text;
                                    break;
                                default:
                                    Console.WriteLine("Não encontado");
                                    break;
                            }
                        //}
                    }
                }
                Console.WriteLine(veiculo.portas);
            }
            catch (Exception ex)
            {
                if(ex is FileNotFoundException || ex is DirectoryNotFoundException)
                {
                    Console.WriteLine("File/Directory not found", ex.Message);
                }                
            }

            if (!found)
            {
                return null;
            }
            else
            {
                return veiculo;
            }
            
        }
        
        public Funcionario login(String nome, String senha)
        {
            Funcionario usuario = new Funcionario();
            bool found = false;

            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(parent.FullName + @"\src\Usuarios.xml");

                foreach (XmlNode node in doc.DocumentElement.ChildNodes)
                {
                    if (found)
                    {
                        break;
                    }
                    foreach (XmlElement child in node)
                    {
                        string childName = child.Name;
                        string text = child.InnerText;
                        if (String.Compare(text.ToLower(), nome.ToLower()) == 0)
                        {
                            Console.WriteLine("Nome Igual");
                            found = true;
                        }
                        if (found)
                        {
                            switch (childName)
                            {
                                case "Nome":
                                    usuario.nome = text;
                                    break;
                                case "Imagem":
                                    usuario.imagePath = @text;
                                    break;
                                case "Senha":
                                    if (String.Compare(text, senha) == 0)
                                    {
                                        Console.WriteLine("Igual!!!");
                                        usuario.senha = text;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Senha diferente");
                                        found = false;
                                    }
                                    break;
                                case "Cargo":
                                    usuario.cargo = text;
                                    break;
                                case "Rua":
                                    usuario.rua = text;
                                    break;
                                case "Numero":
                                    usuario.numero = text;
                                    break;
                                case "Bairro":
                                    usuario.bairro = text;
                                    break;
                                default:
                                    Console.WriteLine("Não encontado");
                                    break;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            if (!found)
            {
                Console.WriteLine("retornando null");
                return null;
            }
            else
            {
                Console.WriteLine("Retornando usuario");
                return usuario;
            }
        }
    }
}
