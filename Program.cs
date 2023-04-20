using System;

namespace gestorDeLivrosl // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static List<Livro> listaLivros = new List<Livro>(); // Lista de livros

        static void Main(string[] args)
        {
            bool sair = false;

            while (!sair)
            {
                Console.WriteLine("Bem-vindo a bliblioteca virtual");
                Console.WriteLine("------------------------------");
                Console.WriteLine("Opções:");
                Console.WriteLine("1 - Cadastrar novo livro");
                Console.WriteLine("2 - Consultar livros cadastrado");
                Console.WriteLine("3 - Buscar um livro");
                Console.WriteLine("4 - Excluir um livro");
                Console.WriteLine("5 - Consulta ao acervo");
                Console.WriteLine("6 - Sair");
                Console.Write("Digite a opção desejada: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        CadastrarLivro();
                        break;
                    case "2":
                        ExibirLivrosCadastrados();
                        break;
                    case "3":
                        BuscarLivros();
                        break;
                    case "4":
                        ExluirUmLivro();
                        break;
                    case "5":
                        ConsultarAcervo();
                        break;
                    case "6":
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void CadastrarLivro()
        {
            Console.WriteLine("Cadastro de Livros");
            Console.WriteLine("-------------------");

            // Solicitar os atributos do proprietário
            Console.WriteLine("Digite o nome do proprietário:");
            string nomeProprietario = Console.ReadLine();

            Console.WriteLine("Digite a matricula do proprietário:");
            string matProprietario = Console.ReadLine();

            Console.WriteLine("Digite o telefone do proprietário:");
            string telefoneProprietario = Console.ReadLine();

            // Criar instância do proprietário
            Proprietario proprietario = new Proprietario(nomeProprietario, matProprietario, telefoneProprietario);

            // Solicitar os detalhes do livro
            Console.WriteLine("Digite o Autor:");
            string autorLivro = Console.ReadLine();

            Console.WriteLine("Digite o nome da Editora:");
            string editoraLivro = Console.ReadLine();

            Console.WriteLine("Digite o nome do livro:");
            string titulo = Console.ReadLine();

            Console.WriteLine("Digite o idioma:");
            string idiomaLivro = Console.ReadLine();

            // Criar instância do carro com o proprietário
            Livro livro = new Livro(autorLivro, editoraLivro, titulo, idiomaLivro, proprietario);

            // Adicionar carro à lista de carros
            listaLivros.Add(livro);

            Console.WriteLine("Cadastrado com sucesso!");
        }

        static void ExibirLivrosCadastrados()
        {
            Console.WriteLine("Livros Cadastrados");
            Console.WriteLine("-------------------");

            // Exibir detalhes dos livros cadastrados
            foreach (var livro in listaLivros)
            {
                Console.WriteLine($"Autor : {livro.Autor}");
                Console.WriteLine($"Editora: {livro.Editora}");
                Console.WriteLine($"Nome do Livro: {livro.Titulo}");
                Console.WriteLine($"Idioma do livro: {livro.Idioma}");
                Console.WriteLine($"Proprietário: {livro.Proprietario.Nome}");
                Console.WriteLine($"Matricula: {livro.Proprietario.Mat}");
                Console.WriteLine($"Telefone de contato: {livro.Proprietario.Telefone}");
                Console.WriteLine("-------------------");
            }
        }

        static void BuscarLivros()
        {
            Console.WriteLine("Buscar Livros");
            Console.WriteLine("-------------------");
            // Solicitar ao usuário o nome do livro a ser buscado
            Console.Write("Digite o nome do livro a ser buscado: ");
            string nomeLivro = Console.ReadLine();

            // Chamar o método de busca de livro da classe Livro e obter o resultado
            Livro livroEncontrado = Livro.BuscarLivro(listaLivros, nomeLivro);

            // Verificar se o livro foi encontrado
            if (livroEncontrado != null)
            {
                Console.WriteLine("Livro encontrado:");
                Console.WriteLine("Título: " + livroEncontrado.Titulo);
                Console.WriteLine("Autor: " + livroEncontrado.Autor);
                Console.WriteLine("Proprietário: " + livroEncontrado.Proprietario.Nome);
                Console.WriteLine($"Telefone de contato: " + livroEncontrado.Proprietario.Telefone);

            }
            else
            {
                Console.WriteLine("Livro não encontrado.");
            }   
        }

        static void ExluirUmLivro()
        {
            Console.WriteLine("Excluir Livro do catalogo");
            Console.WriteLine("-------------------");

            // Solicitar ao usuário o nome do livro a ser buscado
            Console.Write("Digite o nome do livro a ser buscado: ");
            string nomeLivro = Console.ReadLine();

            // Chamar o método de busca de livro da classe Livro e obter o resultado
            Livro livroEncontrado = Livro.BuscarLivro(listaLivros, nomeLivro);

            // Verificar se o livro foi encontrado
            if (livroEncontrado != null)
            {
                Console.WriteLine("Livro encontrado:");
                Console.WriteLine("Título: " + livroEncontrado.Titulo);
                Console.WriteLine("Autor: " + livroEncontrado.Autor);
                Console.WriteLine("Nome do dono " + livroEncontrado.Proprietario.Nome);
                Console.WriteLine($"Telefone de contato: " + livroEncontrado.Proprietario.Telefone);


             // Solicitar confirmação do usuário para excluir o livro
            Console.Write("Deseja excluir o livro? (S/N): ");            
            string confirmacao = Console.ReadLine();

            if (confirmacao.ToUpper() == "S")
            {
                // Chamar o método de exclusão de livro da classe Livro
                if (Livro.ExcluirLivro(listaLivros, nomeLivro))
                {
                    Console.WriteLine("Livro excluído com sucesso.");
                }
                else
                {
                    Console.WriteLine("Falha ao excluir o livro.");
                }
            }
        }
        else
        {
            Console.WriteLine("Livro não encontrado.");
        }
            

        }

        static void ConsultarAcervo()
        {
            Console.WriteLine("-------------------\n");
            Console.WriteLine("Este é o resumo do seu acervo!");          
        
            // Chamar o método para contar o total de livros na lista
            int totalLivros = Livro.ContarLivros(listaLivros);
            Console.WriteLine($"Total de livros: {totalLivros}");

             // Chamar o método para contar o total de livros na lista
            int totalAutores = Livro.ContarAutoresDiferentes(listaLivros);
            Console.WriteLine($"Autores cadastrados: {totalAutores}");

             // Chamar o método para contar o total de livros na lista
            int totalIdiomas = Livro.ContarIdiomas(listaLivros);
            Console.WriteLine($"Variedade de idiomas cadastrados: {totalIdiomas}\n");

            Console.WriteLine("--------FIM-----:)------");
        }
    }
}
