using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class ControlAutor
    {
        
        DAOAutor autor;
        public int opcao;
        public ControlAutor()
        {
            this.autor = new DAOAutor();//Abrindo a conexão com o BD
        }//fim do construtor

        //Mostrar o menu
        public void MostrarMenu()
        {
            Console.WriteLine("----- MENU -----\n\n" +
                "\n0. Sair"                          +
                "\n1. Cadastrar"                     +
                "\n2. Consultar tudo"                +
                "\n3. Consultar por Código"          +
                "\n4. Atualizar"                     +
                "\n5. Excluir"                       +
                "\nEscolha uma das opções acima: ");
            this.opcao = Convert.ToInt32(Console.ReadLine());
        }//fim do método


        public void ExecutarOperacao()
        {
            do
            {
                this.MostrarMenu();//Mostrar as opções disponíveis
                switch (this.opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        Console.WriteLine("Cadastrar Autor");
                        //Formulário de Cadastro
                        Console.WriteLine("Informe o nome do autor: ");
                        string nome = Console.ReadLine();

                        Console.WriteLine("Informe o gênero do autor: ");
                        string genero = Console.ReadLine();

                        Console.WriteLine("Informe o endereço do autor: ");
                        string endereco = Console.ReadLine();

                        //Inserir esses dados no banco
                        this.autor.Inserir(nome, genero, endereco);


                        break;
                    case 2:
                        Console.WriteLine("Consultar Autor");

                        //Chamar o método
                        Console.WriteLine(this.autor.ConsultarTudo());
                        break;
                    case 3:
                        Console.WriteLine("Consultar por Código - Autor");
                        //Pedir o Código
                        Console.WriteLine("Informe um código: ");
                        int codigo = Convert.ToInt32(Console.ReadLine());

                        //Chamar o método
                        Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("Excluir Autor");
                        break;
                    default:
                        Console.WriteLine("Código informado é inválido!");
                        break;
                }//fim do escolha
            } while (this.opcao != 0);
        }//fim do método
        

    }//fim do ControlAutor
}//fim da classe
