class Podcasts
{
    private List<Episodio> episodios = new List<Episodio>();
    public Podcasts(string nome, string host)
    {
        Host = host;
        Nome = nome;
    }
    public string Host { get; }
    public string Nome { get; }
    public int TotalDeEpisodios => episodios.Count();

    public void AdicionarEpisodios(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void MostrarPoscasts()
    {
        Console.WriteLine($"Pocast {Nome} apresentado por {Host}\n");
        foreach( Episodio episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine($"{episodio.Resumo}");
        }
        Console.WriteLine($"\nTotal de epsodios: {TotalDeEpisodios}");
    }
}