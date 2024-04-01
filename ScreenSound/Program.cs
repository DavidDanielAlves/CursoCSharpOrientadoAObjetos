Banda queen = new Banda("The queen");

Album albumDoQueen = new Album("A night at the opera");

Musica musica1 = new Musica(queen, "Love of my life")
{
    Duracao = 213,
    Disponivel = true,
};

Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponivel = false,
};

Podcasts AluraCast = new Podcasts("Alura cast", "David Daniel");

Episodio episodio1 = new Episodio(150, 3, "Inteligencia Artificial");
episodio1.AdicionarConvidado("Lucas Montano");
episodio1.AdicionarConvidado("Atekkita dev");

Episodio episodio2 = new Episodio(150, 3, "Carreira Frontend");
episodio2.AdicionarConvidado("Gui lima");
episodio2.AdicionarConvidado("Monica hillman");

Episodio episodio3 = new Episodio(150, 3, "Carreira Backend");
episodio3.AdicionarConvidado("Mario souto");
episodio3.AdicionarConvidado("joao");

AluraCast.AdicionarEpisodios(episodio1);
AluraCast.AdicionarEpisodios(episodio2);
AluraCast.AdicionarEpisodios(episodio3);

AluraCast.MostrarPoscasts();


