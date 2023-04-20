public class Proprietario
{
    // Atributos da classe Proprietario
    public string Nome { get; set; }
    public string Mat { get; set; }
    public string Telefone { get; set; }

    // Construtor da classe Proprietario
    public Proprietario(string nome, string mat, string telefone)
    {
        Nome = nome;
        Mat = mat;
        Telefone = telefone;
    }

    // Método para exibir os dados do proprietário
    public void ExibirDadosProprietario()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Matricula: {Mat}");
        Console.WriteLine($"Telefone: {Telefone}");
    }
}
