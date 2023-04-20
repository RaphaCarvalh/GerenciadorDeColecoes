public class Livro
{
    // Atributos da classe Carro
    public string Autor { get; set; }
    public string Editora { get; set; }
    public string Titulo { get; set; }
    public string Idioma { get; set; }
    public Proprietario Proprietario { get; set; }

    // Construtor da classe Carro
    public Livro(string autor, string editora, string titulo, string idioma, Proprietario proprietario)
    {
        Autor = autor;
        Editora = editora;
        Titulo = titulo;
        Idioma = idioma;
        Proprietario = proprietario;
    }

    // Método para exibir os dados do livro
    public void ExibirDadosLivros()
    {
        Console.WriteLine($"Autor: {Autor}");
        Console.WriteLine($"Editora: {Editora}");
        Console.WriteLine($"Titulo: {Titulo}");
        Console.WriteLine($"idioma: {Idioma}");
        Console.WriteLine("Proprietário:");
        Proprietario.ExibirDadosProprietario();
    }

    public static Livro BuscarLivro(List<Livro> listaLivros, string titulo)
    {
        // Percorrer a lista de livros e buscar pelo título informado
        foreach (Livro livro in listaLivros)
        {
            if (livro.Titulo == titulo)
            {
                return livro; // Retorna o livro encontrado
            }
        }

        return null; // Retorna null se o livro não for encontrado
    }

     public static bool ExcluirLivro(List<Livro> listaLivros, string titulo)
    {
        // Buscar o livro pelo título
        Livro livroEncontrado = BuscarLivro(listaLivros, titulo);

        if (livroEncontrado != null)
        {
            listaLivros.Remove(livroEncontrado); // Remover o livro da lista
            return true; // Retornar true se o livro for excluído com sucesso
        }

        return false; // Retornar false se o livro não for encontrado na lista
    }
     public static int ContarLivros(List<Livro> listaLivros)
    {
        return listaLivros.Count; // Retorna o total de livros na lista
    }

    public static int ContarAutoresDiferentes(List<Livro> listaLivros)
    {
        HashSet<string> autoresDiferentes = new HashSet<string>();

        foreach (Livro livro in listaLivros)
        {
            autoresDiferentes.Add(livro.Autor); // Adiciona o autor na lista de autores diferentes
        }

        return autoresDiferentes.Count; // Retorna o total de autores diferentes
    }

    public static int ContarIdiomas(List<Livro> listaLivros)
    {
        List<string> idiomasDiferentes = new List<string>();

        foreach (Livro livro in listaLivros)
        {
            idiomasDiferentes.Add(livro.Idioma); // Adiciona o autor na lista de autores diferentes
        }

        return idiomasDiferentes.Count; // Retorna o total de autores diferentes
    }

  

}





