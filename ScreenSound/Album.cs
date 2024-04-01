class Album
{
    private List<Musica> musicas = new List<Musica>();
    public string Nome { get; }

    public Album(string nome)
    {
        Nome = nome;
    }

    public int DuracaoTotao => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}: \n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Musica: {musica.Nome}");
        }
        Console.WriteLine($"Para ouvir este álbum você vai prescisar de {DuracaoTotao} segundos");
    }
}