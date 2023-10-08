
using System;
using System.Collections.Generic;

namespace PaginaLogin
{
    public class Usuarios
    {
        public string NameUser { get; set; }
        public string SenhaUser { get; set; }
    }

    class Program
    {
        // Criação da lista de usuários na classe Program
        static List<Usuarios> Usuarios = new List<Usuarios>();

        static void Main(string[] args)
        {
            Verificar();
        }

        public static void Verificar()
        {
            Console.WriteLine("Digite o nome do usuário:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite a senha do usuário:");
            string senha = Console.ReadLine();

            bool usuarioEncontrado = false;

            // Verificação se o usuário já existe
            foreach (var usuario in Usuarios)
            {
                if (nome == usuario.NameUser && senha == usuario.SenhaUser)
                {
                    usuarioEncontrado = true;
                    break;
                }
            }

            if (usuarioEncontrado)
            {
                Console.WriteLine("Usuário já possui cadastro");
            }
            else
            {
                //cadastro de usuario não existente.
                Incluir(nome, senha);
                Console.WriteLine("Usuário cadastrado com sucesso");
            }
        }

        public static void Incluir(string name, string senha)
        {
            //criando um objeto do tipo Usuarios
            Usuarios Pessoa = new Usuarios();

            Pessoa.NameUser = name;
            Pessoa.SenhaUser = senha;

            // Adicionando o novo usuário à lista existente
            Usuarios.Add(Pessoa);
        }
    }
}
