class Podcast
{
    private List<Episodio> episodios = new List<Episodio>();
    private string Nome { get; }
    private string Host { get; }
    public int TotalEpisodios => episodios.Count;
    Podcast (string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast {Nome} apresentado por {Host}\n");
        foreach(Episodio episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"\n\n Este podcast possui {TotalEpisodios}.episodios");
    }

}