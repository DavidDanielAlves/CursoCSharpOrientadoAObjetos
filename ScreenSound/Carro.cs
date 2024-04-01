class Carro
{
    public string Cor { get; set; }
    public string Nome { get; set; }
    public string Marca { get; set; }
    public int AnoDeLancamento 
    {
        get
        {
            return AnoDeLancamento;   
        }

        set
        {
            if (value > 1960 && value < 2023)
            {
                AnoDeLancamento = value;
            }
        }
    }
    public int VelocidadeMaxima { get; set; }
    public int Velocidade { get; set; }
    public int Som { get; set; }
    public string DescricaoDetalhada => 
        $"O carro {Nome} é da marca {Marca} e da cor {Cor} e foi lançado em {AnoDeLancamento}, sua velocidade maxima atingida é de {VelocidadeMaxima}";

    public void Acelerar() 
    {
        Velocidade += 10;
        Console.WriteLine($"A velocidade do carro é {Velocidade}");
    }

    public void Frear()
    {
        Thread.Sleep(Velocidade * 100);
        Velocidade = 0;
        Console.WriteLine($"A velocidade do carro é {Velocidade}");
    }

    public void Buzinar()
    {
        Som += 10;
    }

}