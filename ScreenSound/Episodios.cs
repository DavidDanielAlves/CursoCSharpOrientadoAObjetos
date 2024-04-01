class Episodio
{
    private List<string> Convidados = new List<string>();

    public Episodio(int duracao, int ordem, string titulo)
    {
        Duracao = duracao;
        Ordem = ordem;
        Titulo = titulo;
    }

    public int Duracao { get; }
    public int Ordem { get; }
    public string Titulo { get; }
    public string Resumo => $"{Titulo}. {Ordem} ({Duracao}min) -> {string.Join(", ", Convidados)}";
    

    public void AdicionarConvidado(string convidado)
    {
        Convidados.Add(convidado);
    }
}