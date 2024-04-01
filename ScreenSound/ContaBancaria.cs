class ContaBancaria
{
    public int NumeroIndicador { get; set; }
    public string Titular { get; set; }
    public int Saldo { get; set; }
    public string Senha { get; set; }

    public void ExibirInformacoesDaConta()
    {
        Console.WriteLine($"Titular: {Titular}");
        Console.WriteLine($"Saldo: {Saldo}");
    }
}