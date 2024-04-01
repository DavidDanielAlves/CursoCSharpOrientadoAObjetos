class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public Banda Artista { get; }
    public string Nome { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoCurta => $"A banda {Nome} pertence à banda {Artista}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Dísponivel no plano.\n");
        }
        else
        {
            Console.WriteLine("Adquira o plano plus+.\n");
        }
    }

}       